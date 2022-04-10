using CefSharp;
using CefSharp.WinForms;
using MiCloudDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCloudDesktop
{
    public partial class MiCloudDesktop : Form
    {

        public MiCloudDesktop()
        {
            InitializeComponent();
            InitalizeCefSharp();
        }

        void InitalizeCefSharp()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            CefSharp.Cef.Initialize(settings);
        }

        private void MiCloudDesktop_Load(object sender, EventArgs e)
        {
            browser_main.Load(Properties.Settings.Default.application_url);
        }

        private void MiCloudDesktop_SizeChanged(object sender, EventArgs e)
        {
        }

        private void btn_main_settings_Click(object sender, EventArgs e)
        {
            AccountManager acManager = new AccountManager();
            acManager.ShowDialog();
        }

        private void btn_main_goback_Click(object sender, EventArgs e)
        {
            if (browser_main.CanGoBack) browser_main.Back();
        }

        private void btn_main_reload_Click(object sender, EventArgs e)
        {
            browser_main.Reload();
        }

        private void btn_main_goforward_Click(object sender, EventArgs e)
        {
            if (browser_main.CanGoForward) browser_main.Forward();
        }
    }
}
