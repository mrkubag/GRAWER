using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SMT_STOPPER_RELEASE.bll;
using SMT_STOPPER_RELEASE.bll.ActiveWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMT_STOPPER_RELEASE
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();

        bool lockedEzcad = false;
        bool connected = false;
        bool home = false;
        bool bypass = false;
        bool auto = false;
        bool pos_updt = false;
        bool after_homing = false;
        bool armed = false;
        bool pos_rdy = false;
        bool start_stage2 = false;
        String comm = "";
        String profpath = "";
        UInt32 act_pos = 0;
        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
        }

        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            if (e.WindowTitle.StartsWith("2.14.11")) //e.WindowTitle.StartsWith("2.14.11")
            {
                activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
                activeWindowWatcher.Stop();
                lockedEzcad = true;
                labelEzcad.Invoke((MethodInvoker)delegate ()
                {
                    labelEzcad.Text = "OKNO EZCAD PRZECHWYCONE";
                    labelEzcad.BackColor = Color.GreenYellow;
                });
                checkBoxArmed.Invoke((MethodInvoker)delegate ()
                {
                    checkBoxArmed.Enabled = true;
                });
                //txtActiveWindow.Text = activeWindow.WindowTitle;
                //txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
                //button1.BackColor = System.Drawing.Color.GreenYellow;
            }
            activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            //lblCurrentlyActiveWindow.Text = $"Active Window: {e.WindowTitle}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            setStatusStrip("BRAK POŁĄCZENIA ZE STEROWNIKIEM");
            textBoxConnection.Text = "Zamknięte";
            //listowanie COM
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                do
                {
                    index += 1;
                    comboBox1.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
               ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Otwórz")
            {
                serialPort1.PortName = Convert.ToString(comboBox1.Text); //przypisanie portu
                serialPort1.BaudRate = 115200; //przypisanie prędkości transmisji
                serialPort1.DataBits = 8; //przypisanie ilości bitów danych
                serialPort1.Parity = Parity.None; //przypisanie parzystości
                serialPort1.StopBits = StopBits.One; //przypisanie bitów stopu
                serialPort1.Handshake = Handshake.None; //przypisanie handshake
                try
                {
                    textBoxConnection.Text = "Łączenie"; //ustawienie tekstu statusu połączenia
                    serialPort1.Open(); //otworzenie portu
                    timer1.Enabled = true; //włączenie timera odpowiedzialnego za odświeżanie aktualnej pozycji
                    var elo = new[] { 'e', 'l', 'o', ';' }; //komenda powitalna, potrzebna aby zweryfikować wybranie odpowiedniego portu
                    serialPort1.Write(elo, 0, 4); //wysłanie komendy powitalnej
                    //serialPort1.Write("cp;");
                    //serialPort1.WriteLine("elo;");
                    buttonConnect.Text = "Zamknij"; //ustawienie tekstu przycisku
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonConnect.Text == "Zamknij")
            {
                try
                {
                    textBoxConnection.Text = "Zamknięte"; //ustawienie tekstu statusu połączenia
                    connected = false; //ustawienie globalnego stanu połaczenia
                    timer1.Stop(); //wyłączenie timera odświeżającego pozycję aktualną
                    serialPort1.Close(); //zamknięcie portu
                    buttonConnect.Text = "Otwórz"; //ustawienie tekstu przycisku
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message); //obsługa błędów
                }
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                do
                {
                    index += 1;
                    comboBox1.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
               ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
            }
        }

        private void updt()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    if(pos_updt)
                    serialPort1.Write(new[] { 'c', 'p', ';' }, 0, 3);
                }
                
            }
            catch (UnauthorizedAccessException ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message); //obsługa błędów
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var edb = new char[20];
            String odebrane = "";
            if (serialPort1.BytesToRead >= 1)
            {
                odebrane += serialPort1.ReadExisting();
            }
            char DataRec = '\0';
            if (odebrane.IndexOf(';') != -1)
            {
                if (!connected)
                {
                    if (odebrane.StartsWith("elo"))
                    {
                        connected = true;
                        timer1.Start();
                        textBoxConnection.Invoke((MethodInvoker)delegate ()
                        {
                            textBoxConnection.Text = "OK";
                        });

                        setStatusStrip("POŁĄCZONO ZE STEROWNIKIEM");
                        setModeManual();
                    }
                    else
                    {
                        textBoxConnection.Invoke((MethodInvoker)delegate ()
                        {
                            textBoxConnection.Text = "BŁĄD";
                        });
                    }
                    odebrane = "";
                }
                else
                {
                    if (odebrane.StartsWith("p:"))
                    {
                        string inp = "";
                        inp = odebrane.Substring(2, odebrane.IndexOf(';') - 2);
                        UInt32 pos = Convert.ToUInt32(inp);
                        act_pos = pos;
                        textBoxCurPos.Invoke((MethodInvoker)delegate ()
                        {
                            textBoxCurPos.Text = Convert.ToString(Math.Round((pos * ((2.0 / 360.0) * (1.0 / 8.0) * 1.8)), 2));
                        });
                    }
                    
                    else if (odebrane.StartsWith("BOARD_RDY"))
                    {
                        if (armed && lockedEzcad) {
                            WindowAPI.SendKeys(activeWindow.WindowHandle, false, false, "F2");
                        }

                        statusStrip1.Invoke((MethodInvoker)delegate ()
                        {
                            statusStripLabel.Text = "PŁYTKA DO WYPALENIA";
                            //buttonPass.BackColor = Color.GreenYellow;
                        });
                        buttonPass.Invoke((MethodInvoker)delegate ()
                        {
                            if(!auto && !bypass)
                            {
                                buttonPass.Enabled = true;

                            }
                            //buttonPass.BackColor = Color.GreenYellow;
                        });
                    }
                    else if (odebrane.StartsWith("HOME_ON"))
                    {
                        pos_updt = false;
                        setStatusStrip("POZYCJA 0");
                        home = true;
                        if (start_stage2)
                        {
                            start_stage2 = false;
                            buttonStart.Invoke((MethodInvoker)delegate ()
                            {
                                buttonStart.Enabled = true;
                            });

                            //start_seq();
                        }
                    }
                    else if (odebrane.StartsWith("POS_RDY"))
                    {

                        pos_rdy = true;
                        setStatusStrip("STOPER NA POZYCJI");
                    }
                    else if (odebrane.StartsWith("HOME_OFF"))
                    {
                        home = false;
                    }
                    else if (odebrane.StartsWith("PASS"))
                    {
                        setStatusStrip("PŁYTKA WYPALONA");
                    }
                    odebrane = "";
                }
            }

        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("dir1;");
            //serialPort1.WriteLine("cont1;");
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {

        }

        void setStatusStrip(string t)
        {
            statusStrip1.Invoke((MethodInvoker)delegate ()
            {
                statusStripLabel.Text = t;
                //buttonPass.BackColor = Color.GreenYellow;
            });
        }

        private void buttonForward_MouseDown(object sender, MouseEventArgs e)
        {
            pos_updt = true;
            serialPort1.Write("dir0;");
            serialPort1.Write("cont1;");
        }

        private void buttonForward_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("cont0;");
            pos_updt = false;
        }

        private void buttonBackward_MouseDown(object sender, MouseEventArgs e)
        {
            pos_updt = true;
            serialPort1.Write("dir1;");
            serialPort1.Write("cont1;");
        }

        private void buttonBackward_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("cont0;");
            pos_updt = false;
        }

        private void Move_Pos_Click(object sender, EventArgs e)
        {
            serialPort1.Write("pos");
            //Double mmPos = (Convert.ToDouble(textBoxGoToPos.Text)*100000.0) / 125.0;
            UInt32 rPos = Convert.ToUInt32(newPos.Value / Convert.ToDecimal(0.00125));
            //Dodać odpowiedni mnożnik
            uint[] target = new uint[] { rPos };
            byte[] decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            byte[] buf = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            serialPort1.Write(buf, 0, 4);
            serialPort1.Write(";");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updt();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (!home)
            {
                pos_updt = true;
                setStatusStrip("USTALANIE POZYCJI 0");
                serialPort1.Write("home;");
                after_homing = true;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (auto)
            {
                auto = false;
                doneButton.BackColor = Color.FromArgb(255, 128, 128);
                serialPort1.Write("auto0;");
            }
            else
            {
                auto = true;
                

                doneButton.BackColor = Color.GreenYellow;
                serialPort1.Write("auto1;");
            }
        }

        private void bypassButton_Click(object sender, EventArgs e)
        {
            if (bypass)
            {
                bypass = false;
                serialPort1.Write("bypass0;");
                bypassButton.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                bypass = true;
                serialPort1.Write("bypass1;");
                bypassButton.BackColor = Color.GreenYellow;
            }
        }

        void refrProf()
        {
            comboBoxProfile.Items.Clear();
            ISheet sheet;
            //            string strDoc = "C:\\Users\\Public\\Documents\\testdata.xlsx";
            var stream = new FileStream(profpath, FileMode.Open);
            stream.Position = 0;
            XSSFWorkbook xssWorkbook = new XSSFWorkbook(stream);
            sheet = xssWorkbook.GetSheetAt(0);
            int ilosc_wierszy = sheet.LastRowNum + 1;
            IRow row = sheet.GetRow(1);
            for (int j = 1; j < ilosc_wierszy; j++)
            {
                row = sheet.GetRow(j);
                comboBoxProfile.Items.Add(row.GetCell(0));
            }
            comboBoxProfile.SelectedIndex = 0;
        }

        private void buttonRefrProf_Click(object sender, EventArgs e)
        {
            refrProf();
        }

        private void buttonLoadProf_Click(object sender, EventArgs e)
        {
            ISheet sheet;
            var stream = new FileStream(profpath, FileMode.Open);
            stream.Position = 0;
            XSSFWorkbook xssWorkbook = new XSSFWorkbook(stream);
            sheet = xssWorkbook.GetSheetAt(0);
            int ilosc_wierszy = sheet.LastRowNum + 1;
            IRow row = sheet.GetRow(0);
            for (int j = 1; j < ilosc_wierszy; j++)
            {
                row = sheet.GetRow(j);
                if(row.GetCell(0).ToString() == Convert.ToString(comboBoxProfile.Text))
                {
                    czasWypalaniaProf.Value = Convert.ToDecimal(row.GetCell(2).NumericCellValue);
                    pozycjaZadProf.Value = Convert.ToDecimal(row.GetCell(1).NumericCellValue);
                }
            }
        }

        private void czasWypalania_ValueChanged(object sender, EventArgs e)
        {
            serialPort1.Write("t:");
            UInt32 auto_t_t = Convert.ToUInt32(czasWypalania.Value * 1000);
            uint[] target = new uint[] { auto_t_t };
            byte[] decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            byte[] buf = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            byte[] t = new byte[2];
            t[0] = buf[2];
            t[1] = buf[3];
            serialPort1.Write(t, 0, 2);
            serialPort1.Write(";");
            setStatusStrip("ZMIENIONO CZAS WYPALANIA");
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            serialPort1.Write("done;");
            buttonPass.Enabled = false;
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            int a = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            setModeManual();

            if (!after_homing)
            {
                buttonStart.BackColor = Color.Yellow;
                buttonStart.Enabled = false;
                serialPort1.Write("home;");
                after_homing = true;
                pos_updt = true;
                start_stage2 = true;
                setStatusStrip("USTALANIE POZYCJI 0");
                //buttonStart.Enabled = false;
                //buttonStop.Enabled = true;
            }
            else
            {
                buttonStart.BackColor = Color.YellowGreen;
                buttonStart.Enabled = false;
                start_seq();
                buttonStop.Enabled = true;
            }
            
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStart.BackColor = Color.Yellow;
            checkBoxArmed.Checked = false;
            armed = false;
            serialPort1.Write("auto0;");
            serialPort1.Write("reset;");
            serialPort1.Write("bypass1;");
            buttonStop.Enabled = false;
        }

        private void start_seq()
        {
            setStatusStrip("USTALANIE CZASU WYPALANIA");
            serialPort1.Write("t:");
            UInt32 auto_t_t = Convert.ToUInt32(czasWypalaniaProf.Value * 1000);
            uint[] target = new uint[] { auto_t_t };
            byte[] decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            byte[] buf = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            byte[] t = new byte[2];
            t[0] = buf[2];
            t[1] = buf[3];
            serialPort1.Write(t, 0, 2);
            serialPort1.Write(";");

            setStatusStrip("USTALANIE POZYCJI STOPERA");
            serialPort1.Write("pos");
            UInt32 rPos = Convert.ToUInt32(pozycjaZadProf.Value / Convert.ToDecimal(0.00125));
            //setStatusStrip(Convert.ToString(pozycjaZadProf.Value));
            target = new uint[] { rPos };
            decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            serialPort1.Write(buf, 0, 4);
            serialPort1.Write(";");

            setModeAuto();
        }

        private void buttonSaveProf_Click(object sender, EventArgs e)
        {
            //string strDoc = "C:\\Users\\Public\\Documents\\testdata.xlsx";
            var stream = new FileStream(profpath, FileMode.Open, FileAccess.ReadWrite);
            stream.Position = 0;
            ISheet sheet;
            IWorkbook xssWorkbook = new XSSFWorkbook(stream);
            sheet = xssWorkbook.GetSheetAt(0);
            IRow row = sheet.CreateRow(sheet.LastRowNum+1);

            row.CreateCell(0).SetCellValue(textBoxNewProfName.Text);
            row.CreateCell(1).SetCellValue(Convert.ToDouble(pozycjaZadProf.Value));
            row.CreateCell(2).SetCellValue(Convert.ToDouble(czasWypalaniaProf.Value));
            FileStream file = new FileStream(profpath, FileMode.Create);
            xssWorkbook.Write(file);
            file.Close();
            //xssWorkbook.Write(stream);
        }

        private void checkBoxArmed_CheckedChanged(object sender, EventArgs e)
        {
            armed = checkBoxArmed.Checked;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!connected)
            {
                //tabControl1.SelectTab(0);
            }
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            profpath = openFileDialog1.FileName;
            refrProf();

        }

        private void setModeBypass()
        {
            serialPort1.Write("auto0;");
            auto = false;
            bypass = true;
            serialPort1.Write("bypass1;");
            doneButton.Invoke((MethodInvoker)delegate () {
                doneButton.BackColor = Color.FromArgb(255, 128, 128);
            });
            bypassButton.Invoke((MethodInvoker)delegate () {
                bypassButton.BackColor = Color.YellowGreen;
            });
        }

        private void setModeAuto()
        {
            serialPort1.Write("auto1;");
            auto = true;
            bypass = false;
            serialPort1.Write("bypass0;");
            doneButton.Invoke((MethodInvoker)delegate () {
                doneButton.BackColor = Color.YellowGreen;
            });
            bypassButton.Invoke((MethodInvoker)delegate () {
                bypassButton.BackColor = Color.FromArgb(255, 128, 128);
            });
        }

        private void setModeManual()
        {
            serialPort1.Write("auto0;");
            auto = false;
            bypass = false;
            serialPort1.Write("bypass0;");
            doneButton.Invoke((MethodInvoker)delegate () {
                doneButton.BackColor = Color.FromArgb(255, 128, 128);
            });
            bypassButton.Invoke((MethodInvoker)delegate () {
                bypassButton.BackColor = Color.FromArgb(255, 128, 128);
            });
            
            
        }

        private void buttonResetEZCAD_Click(object sender, EventArgs e)
        {
            activeWindowWatcher.Start();
            lockedEzcad = false;
            labelEzcad.Invoke((MethodInvoker)delegate ()
            {
                labelEzcad.Text = "PROSZĘ OTWORZYĆ OKNO EZCAD";
                labelEzcad.BackColor = Color.FromArgb(255,128,128);
            });
            checkBoxArmed.Invoke((MethodInvoker)delegate ()
            {
                checkBoxArmed.Enabled = false;
            });
        }

        private void ButtonApply(object sender, EventArgs e)
        {
            setStatusStrip("USTALANIE CZASU WYPALANIA");
            serialPort1.Write("t:");
            UInt32 auto_t_t = Convert.ToUInt32(czasWypalaniaProf.Value * 1000);
            uint[] target = new uint[] { auto_t_t };
            byte[] decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            byte[] buf = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            byte[] t = new byte[2];
            t[0] = buf[2];
            t[1] = buf[3];
            serialPort1.Write(t, 0, 2);
            serialPort1.Write(";");

            setStatusStrip("USTALANIE POZYCJI STOPERA");
            serialPort1.Write("pos");
            UInt32 rPos = Convert.ToUInt32(pozycjaZadProf.Value / Convert.ToDecimal(0.00125));
            //setStatusStrip(Convert.ToString(pozycjaZadProf.Value));
            target = new uint[] { rPos };
            decoded = new byte[target.Length * sizeof(uint)];
            Buffer.BlockCopy(target, 0, decoded, 0, decoded.Length);
            for (int i = 0; i < 4; i++)
            {
                buf[i] = decoded[3 - i];
            }
            serialPort1.Write(buf, 0, 4);
            serialPort1.Write(";");
        }
    }
}
