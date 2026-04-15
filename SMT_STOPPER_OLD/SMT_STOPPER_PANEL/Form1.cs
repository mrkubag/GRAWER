using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMT_STOPPER_PANEL
{
    public partial class Form1 : Form
    {
        bool connected = false;
        bool solenoid = false;
        bool smema = false;
        bool laser = false;
        bool home = false;
        bool bypass = false;
        String comm="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLaser.Stop();
            timerSmema.Stop();
            timerSolenoid.Stop();

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
                    serialPort1.Write(elo,0,4); //wysłanie komendy powitalnej
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
                serialPort1.Write(new[] { 'c', 'p', ';' }, 0, 3);
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
            String odebrane="";
            if (serialPort1.BytesToRead >= 20) { 
                odebrane = serialPort1.ReadExisting(); 
            }
            char DataRec = '\0';
                if (odebrane.IndexOf(';')!=-1)
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
                    if(!odebrane.StartsWith("p:"))  {
                        textBoxState.Invoke((MethodInvoker)delegate ()
                        {
                            textBoxState.Text = odebrane;
                        });
                    }
                    if (odebrane.StartsWith("p:"))
                        {
                        string inp = "";
                        inp = odebrane.Substring(2,odebrane.IndexOf(';')-2);
                        UInt32 pos = Convert.ToUInt32(inp);
                        textBoxCurPos.Invoke((MethodInvoker)delegate ()
                            {
                                textBoxCurPos.Text = Convert.ToString(Math.Round((pos*((2.0/360.0)*(1.0/8.0)*1.8)),2));
                            });
                    }else if (odebrane.StartsWith("SOL_ON"))
                    {
                        solenoid = true;
                        buttonSolenoid.Invoke((MethodInvoker)delegate ()
                        {
                            buttonSolenoid.BackColor = Color.GreenYellow;
                        });
                    } else if (odebrane.StartsWith("SOL_OFF"))
                    {
                        buttonSolenoid.Invoke((MethodInvoker)delegate ()
                        {
                            buttonSolenoid.BackColor = Color.FromArgb(255, 128, 128);
                        });
                        solenoid = false;
                    }
                    else if (odebrane.StartsWith("LASER_ON"))
                    {
                        buttonLaser.Invoke((MethodInvoker)delegate ()
                        {
                            buttonLaser.BackColor = Color.GreenYellow;
                        });
                        laser = true;
                    }
                    else if (odebrane.StartsWith("LASER_OFF"))
                    {
                        buttonLaser.Invoke((MethodInvoker)delegate ()
                        {
                            buttonLaser.BackColor = Color.FromArgb(255, 128, 128);
                        });
                        laser = false;
                    }
                    else if (odebrane.StartsWith("SMEMA_ON"))
                    {
                        buttonSmema.Invoke((MethodInvoker)delegate ()
                        {
                            buttonSmema.BackColor = Color.GreenYellow;
                        });
                        smema = true;
                    }
                    else if (odebrane.StartsWith("SMEMA_OFF"))
                    {
                        buttonSmema.Invoke((MethodInvoker)delegate ()
                        {
                            buttonSmema.BackColor = Color.FromArgb(255, 128, 128);
                        });
                        smema = false;
                    }
                    else if (odebrane.StartsWith("HOME_ON"))
                    {
                        home_label.Invoke((MethodInvoker)delegate ()
                        {
                            home_label.BackColor = Color.GreenYellow;
                        });
                        home = true;
                    }
                    else if (odebrane.StartsWith("HOME_OFF"))
                    {
                        home_label.Invoke((MethodInvoker)delegate ()
                        {
                            home_label.BackColor = Color.FromArgb(255, 128, 128);
                        });
                        home = false;
                    }
                    else if (odebrane.StartsWith("BOARD_RDY"))
                    {
                        doneButton.Invoke((MethodInvoker)delegate ()
                        {
                            doneButton.Enabled = true;
                            doneButton.BackColor = Color.GreenYellow;
                        });
                        home = false;
                    }
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

        private void buttonForward_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("dir0;");
            serialPort1.Write("cont1;");
        }

        private void buttonForward_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("cont0;");
        }

        private void buttonBackward_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("dir1;");
            serialPort1.Write("cont1;");
        }

        private void buttonBackward_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("cont0;");
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

        

        private void buttonSolenoid_Click(object sender, EventArgs e)
        {
            if (checkBoxSolenoid.Checked && !solenoid) {
                serialPort1.Write("sol1");
                timerSolenoid.Interval = Convert.ToInt32(textBoxSolenoid.Text);
                timerSolenoid.Start();
            }
            else
            {
                if (solenoid)
                {
                    serialPort1.Write("sol0");
                }
                else
                {
                    serialPort1.Write("sol1");
                }
            }

        }

        private void buttonSmema_Click(object sender, EventArgs e)
        {
            if (checkBoxSmema.Checked && !smema)
            {
                serialPort1.Write("smema1");
                timerSmema.Interval = Convert.ToInt32(textBoxSmema.Text);
                timerSmema.Start();
            }
            else
            {
                if (smema)
                {
                    serialPort1.Write("smema0");
                }
                else
                {
                    serialPort1.Write("smema1");
                }
            }
        }

        private void buttonLaser_Click(object sender, EventArgs e)
        {
            if (checkBoxLaser.Checked && !laser)
            {
                serialPort1.Write("laser1");
                timerLaser.Interval = Convert.ToInt32(textBoxLaser.Text);
                timerLaser.Start();
            }
            else
            {
                if (laser)
                {
                    serialPort1.Write("laser0");
                }
                else
                {
                    serialPort1.Write("laser1");
                }
            }
        }

        private void timerSolenoid_Tick(object sender, EventArgs e)
        {
            if (solenoid)
            {
                serialPort1.Write("sol0");
                timerSolenoid.Stop();
            }
        }

        private void timerSmema_Tick(object sender, EventArgs e)
        {
            if (smema)
            {
                serialPort1.Write("smema0");
                timerSmema.Stop();
            }
        }

        private void timerLaser_Tick(object sender, EventArgs e)
        {
            if (laser)
            {
                serialPort1.Write("laser0");
                timerLaser.Stop();
            }
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
                serialPort1.Write("home;");
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("done;");
            doneButton.BackColor = Color.FromArgb(255,128,128);
            doneButton.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("reset;");
        }
    }
}
