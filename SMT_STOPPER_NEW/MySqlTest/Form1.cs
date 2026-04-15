using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string M_str_sqlcon = "server="+textBox1.Text+";uid="+textBox2.Text+";pwd="+textBox3.Text+";database=laser;SslMode="+textBox4.Text;
            using (var mySqlCn = new MySqlConnection(M_str_sqlcon))
            {
                using (var mySqlCmd = new MySqlCommand("select * from datamatrix", mySqlCn))
                {
                    try
                    {
                        mySqlCn.Open();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    using (MySqlDataReader mySqlReader = mySqlCmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (mySqlReader.Read())
                        {
                            //setStatusStrip($"{mySqlReader.GetString(0)}:{mySqlReader.GetString(1)}");
                            Debug.WriteLine($"{mySqlReader.GetString(0)}:{mySqlReader.GetString(1)}");
                            MessageBox.Show($"{mySqlReader.GetString(0)}:{mySqlReader.GetString(1)}");
                        }
                    }
                }
            }
        }
    }
}
