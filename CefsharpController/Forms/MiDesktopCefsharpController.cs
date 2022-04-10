using Codeer.Friendly.Dynamic;
using MiCloudDesktop.Classes;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using ekayic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.CefSharp.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CefsharpController
{
    public partial class MiDesktopCefsharpController : Form
    {
        WindowsAppFriend _app;
        CefSharpDriver _driver;

        string MiCloudDesktopPath = Application.StartupPath + @"\lib\bin\";
        int tryLoginAttempt = 0;
        public MiDesktopCefsharpController()
        {
            InitializeComponent();

            try
            {
                var process = Process.Start(MiCloudDesktopPath+ "MiCloudDesktop.exe");

                //attach by friendly.
                _app = new WindowsAppFriend(process);

                //show next dialog.
                var mainWindow = _app.WaitForIdentifyFromTypeFullName("MiCloudDesktop.MiCloudDesktop");

                _driver = new CefSharpDriver(mainWindow.Dynamic().browser_main);

                Thread.Sleep(2000);

                while (login() && tryLoginAttempt < 2)
                {
                    _driver.Url = "https://i.mi.com/";
                    _driver.Navigate();
                }
            }
            catch { if (!Directory.Exists(MiCloudDesktopPath)){ Thread.Sleep(200); Application.Restart(); } throw; }

        }

        private bool login()
        {
            try
            {
                var acInfo = XmlHelper.XmlDeserialize(typeof(AccountInfo), MiCloudDesktopPath + @"accountinfo.xml") as AccountInfo;

                if (acInfo == null) return false;

                var account_element = _driver.FindElementByXPath(@"/html/body/div[1]/div/div/div[2]/div/div/div[2]/div/div[2]/div[3]/div[1]/form/div[1]/div[1]/div[2]/div/div/div/div/input");
                account_element.SendKeys(acInfo.UserName ?? "");

                var password_element = _driver.FindElementByXPath(@"/html/body/div[1]/div/div/div[2]/div/div/div[2]/div/div[2]/div[3]/div[1]/form/div[1]/div[2]/div[1]/div[1]/div/input");
                password_element.SendKeys(acInfo.Password ?? "");

                Thread.Sleep(100);

                var submit_element = _driver.FindElementByXPath(@"/html/body/div[1]/div/div/div[2]/div/div/div[2]/div/div[2]/div[3]/div[1]/form/div[1]/button");
                submit_element.Click();
                return true;
            }
            catch { return false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            Close();
        }
    }
}
