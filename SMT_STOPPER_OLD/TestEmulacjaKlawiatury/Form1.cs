using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendKeys.BLL;
using SendKeys.BLL.ActiveWindow;


namespace TestEmulacjaKlawiatury
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();

        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
        }

        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            lblCurrentlyActiveWindow.Text = $"Active Window: {e.WindowTitle}";
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            activeWindowWatcher.Stop();
            txtActiveWindow.Text = activeWindow.WindowTitle;
            txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, rbtCTRL.Checked, rbtALT.Checked, cboLetter.Text);
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            WindowAPI.SendKeys(activeWindow.WindowHandle, e.KeyChar.ToString());
            WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
        }
    }
}
