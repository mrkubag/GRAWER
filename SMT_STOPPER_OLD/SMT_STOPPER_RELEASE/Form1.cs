using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NPOI.Util;
using SMT_STOPPER_RELEASE.bll;
using SMT_STOPPER_RELEASE.bll.ActiveWindow;

namespace SMT_STOPPER_RELEASE
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();

        const string M_str_sqlcon = "server=localhost;uid=root;pwd=Mikronika123;database=laser;SslMode=none;AllowPublicKeyRetrieval=True";

        bool lockedEzcad = false;
        bool connected = false;
        bool home = false;
        bool bypass = false;
        bool auto = false;
        bool pos_updt = false;
        bool after_homing = false;
        bool armed = false;
        bool licznik = false;
        bool pos_rdy = false;
        bool start_stage2 = false;
        String comm = "";
        String profpath = "";
        UInt32 act_pos = 0;
        string skan = "";
        bool git = true;

        String odebrane = "";
        string[] str;
        string[] str_sets;
        public static SerialPort skanerStatic = new SerialPort();
        

        int licznikTimerSkaner = 0;
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
            skanerStatic = serialPortSkaner;

            using (var mySqlCn = new MySqlConnection(M_str_sqlcon))
            {
                try
                {
                    mySqlCn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    mySqlCn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
                    timerSkaner.Enabled = true;
            timerSkaner.Stop();

            buttonConnect.Focus();
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
                    comboBox2.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
               ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Otwórz port")
            {
                serialPort1.PortName = Convert.ToString(comboBox1.Text); //przypisanie portu
                serialPort1.BaudRate = 115200; //przypisanie prędkości transmisji
                serialPort1.DataBits = 8; //przypisanie ilości bitów danych
                serialPort1.Parity = Parity.None; //przypisanie parzystości
                serialPort1.StopBits = StopBits.One; //przypisanie bitów stopu
                serialPort1.Handshake = Handshake.None; //przypisanie handshake

                serialPortSkaner.PortName = Convert.ToString(comboBox2.Text);

                try
                {
                    serialPortSkaner.Open();
                    textBoxConnection.Text = "Łączenie"; //ustawienie tekstu statusu połączenia
                    serialPort1.Open(); //otworzenie portu
                    timer1.Enabled = true; //włączenie timera odpowiedzialnego za odświeżanie aktualnej pozycji
                    var elo = new[] { 'e', 'l', 'o', ';' }; //komenda powitalna, potrzebna aby zweryfikować wybranie odpowiedniego portu
                    serialPort1.Write(elo, 0, 4); //wysłanie komendy powitalnej
                    //serialPort1.Write("cp;");
                    //serialPort1.WriteLine("elo;");
                    
                    buttonConnect.Text = "Zamknij port"; //ustawienie tekstu przycisku
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonConnect.Text == "Zamknij port")
            {
                try
                {
                    textBoxConnection.Text = "Zamknięte"; //ustawienie tekstu statusu połączenia
                    connected = false; //ustawienie globalnego stanu połaczenia
                    buttonsEnable(false);
                    timer1.Stop(); //wyłączenie timera odświeżającego pozycję aktualną
                    serialPort1.Close(); //zamknięcie portu
                    serialPortSkaner.Close();
                    buttonConnect.Text = "Otwórz port"; //ustawienie tekstu przycisku
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
            comboBox2.Items.Clear();
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
                    comboBox2.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index ==
               ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
            }
        }

        private void sendPos(Decimal pos_send)
        {
            UInt32 auto_t_t = Convert.ToUInt32(pos_send * 1000);
            uint[] target = new uint[] { auto_t_t };
            byte[] decoded = new byte[target.Length * sizeof(uint)];
            byte[] buf = new byte[4];
            serialPort1.Write("pos");
            UInt32 rPos = Convert.ToUInt32(pos_send / Convert.ToDecimal(0.00125));
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
            pos_updt = true;
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
                        buttonsEnable(true);
                        textBoxConnection.Invoke((MethodInvoker)delegate ()
                        {
                            textBoxConnection.Text = "OK";
                        });

                        setStatusStrip("POŁĄCZONO ZE STEROWNIKIEM");
                        setModeManual();
                        //sendPos(10);
                        if (!after_homing)
                        {
                            pos_updt = true;
                            setStatusStrip("USTALANIE POZYCJI 0");
                            serialPort1.Write("home;");
                            after_homing = true;
                        }
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
                        if (armed && lockedEzcad)
                        {
                            WindowAPI.SendKeys(activeWindow.WindowHandle, false, false, "F2");
                            
                        }

                        if (checkBoxLicznik.Checked && (numericUpDownLicznik.Value != 0) && (numericUpDownLicznik.Value > numericUpDownLicznikMnoznik.Value))
                        {
                            numericUpDownLicznik.Invoke((MethodInvoker)delegate ()
                            {
                                numericUpDownLicznik.Value -= numericUpDownLicznikMnoznik.Value;
                            });
                            
                        }

                        statusStrip1.Invoke((MethodInvoker)delegate ()
                        {
                            statusStripLabel.Text = "PŁYTKA DO WYPALENIA";
                            //buttonPass.BackColor = Color.GreenYellow;
                        });

                        buttonPass.Invoke((MethodInvoker)delegate ()
                        {
                            if (!auto && !bypass)
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
                    }
                    else if (odebrane.StartsWith("POS_RDY"))
                    {
                        pos_updt = false;
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
                        if (licznik && ((numericUpDownLicznik.Value == 0)||(numericUpDownLicznik.Value < numericUpDownLicznikMnoznik.Value)) )
                        {
                            setModeManual();
                            checkBoxArmed.Checked = false;
                            numericUpDownLicznik.BackColor = Color.Red;
                        }
                    }
                    odebrane = "";
                }
            }

        }

        void buttonsEnable(bool state)
        { 

            buttonZast.Invoke((MethodInvoker)delegate ()
            {
                buttonZast.Enabled = state;
            });

            buttonPosRefr.Invoke((MethodInvoker)delegate ()
            {
                buttonPosRefr.Enabled = state;
            });

            bypassButton.Invoke((MethodInvoker)delegate ()
            {
                bypassButton.Enabled = state;
            });
            
            doneButton.Invoke((MethodInvoker)delegate ()
            {
                doneButton.Enabled = state;
            });

        }

        void setStatusStrip(string t)
        {
            statusStrip1.Invoke((MethodInvoker)delegate ()
            {
                statusStripLabel.Text = t;
                //buttonPass.BackColor = Color.GreenYellow;
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updt();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            if (auto) { 
                setModeManual();
            }
            else
            {
                setModeAuto();
            }
        }

        private void bypassButton_Click(object sender, EventArgs e)
        {
            if (bypass)
            {
                setModeManual();
            }
            else
            {
                setModeBypass();
            }
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            serialPort1.Write("done;");
            buttonPass.Enabled = false;
        }

        private void checkBoxArmed_CheckedChanged(object sender, EventArgs e)
        {
            armed = checkBoxArmed.Checked;
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
            bypassButton.Invoke((MethodInvoker)delegate ()
            {
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
            pos_updt = true;
        }

        private void buttonPosRefr_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                serialPort1.Write(new[] { 'c', 'p', ';' }, 0, 3);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxLicznik_CheckedChanged(object sender, EventArgs e)
        {
            licznik = checkBoxLicznik.Checked;
            if (checkBoxLicznik.Checked) { 
                groupBoxLiczIlo.Enabled = true;
                groupBoxLiczMno.Enabled = true;
            }
            else
            {
                groupBoxLiczIlo.Enabled = false;
                groupBoxLiczMno.Enabled = false;
            }
        }

        private void numericUpDownLicznik_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownLicznik.Value > 0)
            {
                numericUpDownLicznik.BackColor = Color.White;
            }
        }

        private void serialPortSkaner_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count = 1;
            int sets = 0;
            int rows = 0;
            string odb_test = "";
            if (serialPortSkaner.BytesToRead > 0)
            {
                odb_test = serialPortSkaner.ReadExisting();
                odebrane += odb_test; 
                //richTextBox1.Text += odb_test;
            }
            if (odebrane.IndexOf('\r') != -1)
            {
                if (odebrane.IndexOf("ERROR") > -1)
                {
                    MessageBox.Show("Błąd odczytu!");
                }else if (odebrane.IndexOf("OK") > -1)
                {
                    odebrane = "";
                    serialPortSkaner.DiscardInBuffer();
                }
                else if (odebrane.IndexOf('|') > -1)
                {
                    git = true;
                    char[] tr = { '|', '\r' };
                    str_sets = odebrane.TrimEnd(tr).Split(',');
                    count = str_sets.Length;
                    sets = count;
                    richTextBox1.Text += "\r"+ "Sets:"+sets.ToString();
                    //MessageBox.Show("insert into datamatrix (nr,nr_zam,data_przyj) values (" + str[0] + "," + str[1] + "," + str[2] + ");");


                    using (var mySqlCn = new MySqlConnection(M_str_sqlcon))
                        {
                        using (var mySqlCmd = new MySqlCommand())
                        {
                            mySqlCmd.Connection = mySqlCn;
                            try
                            {
                                mySqlCn.Open();
                                richTextBox1.Text += '\r' + "Open: ";
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                                git = false;
                            }
                            for (int i = 0; i < sets; i++)
                            {
                            str = str_sets[i].Split(';');
                            richTextBox1.Text += '\r' + "Str " + i.ToString();
                            //MessageBox.Show("insert into datamatrix (nr,nr_zam,data_przyj) values (" + str[0] + "," + str[1] + "," + str[2] + ");");
                                mySqlCmd.CommandText = "insert into datamatrix (code,order_num,date) values (" + str[0] + "," + str[1] + ",'" + str[2] + "');";

                                try
                                {
                                    rows = mySqlCmd.ExecuteNonQuery();
                                    richTextBox1.Text += '\r' + "Cmd: " + i.ToString();
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    git = false;
                                    odebrane = "";
                                    continue;
                                }

                                if (rows < 0)
                                {
                                    MessageBox.Show("PROBLEM Z WYPALANYM KODEM:" + str[0], "ERROR");
                                    git = false;
                                    odebrane = "";
                                }
                            }
                            try
                            {
                                mySqlCn.Close();
                                richTextBox1.Text += '\r' + "Close: ";
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                                git = false;
                            }

                        }
                    }

                    if (git)
                    {
                        //MessageBox.Show("Sukces");
                        serialPortSkaner.Write("OUTON,1\r");
                        //MessageBox.Show("OUTON");
                        var task1 = OUTOFF(150);

                    }
                    else
                    {
                        setModeManual();
                        git = true;
                        //MessageBox.Show("PROBLEM Z WYPALONYM KODEM","ERROR");
                    }
                }
                odebrane = "";

                
                //OUTON,1
                //OUTOFF,1 
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }


        private static async Task OUTOFF(int milliseconds)
        {
            await Task.Delay(milliseconds);
            //MessageBox.Show("OUTOFF");
            skanerStatic.Write("OUTOFF,1\r");
            //Console.WriteLine($"Task completed after {milliseconds} milliseconds");
        }

        private void numericUpDownLicznikMnoznik_ValueChanged(object sender, EventArgs e)
        {
            //wysłać komende zmienijącą ilosć kodów
            serialPortSkaner.Write("WP,250,"+numericUpDownLicznikMnoznik.Value.ToString()+"\r");
        }
    }
}
