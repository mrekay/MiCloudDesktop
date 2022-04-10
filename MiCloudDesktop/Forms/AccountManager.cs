using ekayic;
using MiCloudDesktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCloudDesktop.Forms
{
    public partial class AccountManager : Form
    {

        AccountInfo accountInfo = new AccountInfo();

        public AccountManager()
        {
            InitializeComponent();
        }

        private void btn_accountmanager_save_Click(object sender, EventArgs e)
        {
            accountInfo.UserName = tb_accountmanager_account.Text;
            accountInfo.Password = tb_accountmanager_password.Text;
            XmlHelper.XmlSerialize(typeof(AccountInfo), accountInfo, Application.StartupPath + @"\accountinfo.xml");
            Close();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            try { 
            var accInfo =  XmlHelper.XmlDeserialize(typeof( AccountInfo), Application.StartupPath + @"\accountinfo.xml") as AccountInfo;
                if (accInfo == null) return;
            accountInfo.UserName = String.IsNullOrEmpty( accInfo.UserName) ? accInfo.UserName : "";
            accountInfo.Password = String.IsNullOrEmpty(accInfo.Password) ? accInfo.Password : "";

                tb_accountmanager_account.Text = accountInfo.UserName;
            tb_accountmanager_password.Text = accountInfo.Password;
            }catch { throw; }
        }
    }
}
