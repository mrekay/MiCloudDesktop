namespace MiCloudDesktop.Forms
{
    partial class AccountManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
            this.lbl_accountmanager_title = new System.Windows.Forms.Label();
            this.lbl_accountmanager_account = new System.Windows.Forms.Label();
            this.tb_accountmanager_account = new System.Windows.Forms.TextBox();
            this.tb_accountmanager_password = new System.Windows.Forms.TextBox();
            this.lbl_accountmanager_password = new System.Windows.Forms.Label();
            this.btn_accountmanager_save = new ekayic.forms.elements.RoundedButton();
            this.SuspendLayout();
            // 
            // lbl_accountmanager_title
            // 
            this.lbl_accountmanager_title.AutoSize = true;
            this.lbl_accountmanager_title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_accountmanager_title.ForeColor = System.Drawing.Color.White;
            this.lbl_accountmanager_title.Location = new System.Drawing.Point(12, 19);
            this.lbl_accountmanager_title.Name = "lbl_accountmanager_title";
            this.lbl_accountmanager_title.Size = new System.Drawing.Size(131, 20);
            this.lbl_accountmanager_title.TabIndex = 0;
            this.lbl_accountmanager_title.Text = "Account Manager";
            // 
            // lbl_accountmanager_account
            // 
            this.lbl_accountmanager_account.AutoSize = true;
            this.lbl_accountmanager_account.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_accountmanager_account.ForeColor = System.Drawing.Color.White;
            this.lbl_accountmanager_account.Location = new System.Drawing.Point(53, 65);
            this.lbl_accountmanager_account.Name = "lbl_accountmanager_account";
            this.lbl_accountmanager_account.Size = new System.Drawing.Size(180, 20);
            this.lbl_accountmanager_account.TabIndex = 1;
            this.lbl_accountmanager_account.Text = "Email/Phone/Mi Account";
            // 
            // tb_accountmanager_account
            // 
            this.tb_accountmanager_account.Location = new System.Drawing.Point(57, 99);
            this.tb_accountmanager_account.Multiline = true;
            this.tb_accountmanager_account.Name = "tb_accountmanager_account";
            this.tb_accountmanager_account.Size = new System.Drawing.Size(312, 25);
            this.tb_accountmanager_account.TabIndex = 2;
            // 
            // tb_accountmanager_password
            // 
            this.tb_accountmanager_password.Location = new System.Drawing.Point(57, 171);
            this.tb_accountmanager_password.Multiline = true;
            this.tb_accountmanager_password.Name = "tb_accountmanager_password";
            this.tb_accountmanager_password.PasswordChar = '•';
            this.tb_accountmanager_password.Size = new System.Drawing.Size(312, 25);
            this.tb_accountmanager_password.TabIndex = 4;
            // 
            // lbl_accountmanager_password
            // 
            this.lbl_accountmanager_password.AutoSize = true;
            this.lbl_accountmanager_password.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_accountmanager_password.ForeColor = System.Drawing.Color.White;
            this.lbl_accountmanager_password.Location = new System.Drawing.Point(53, 137);
            this.lbl_accountmanager_password.Name = "lbl_accountmanager_password";
            this.lbl_accountmanager_password.Size = new System.Drawing.Size(73, 20);
            this.lbl_accountmanager_password.TabIndex = 3;
            this.lbl_accountmanager_password.Text = "Password";
            // 
            // btn_accountmanager_save
            // 
            this.btn_accountmanager_save.BorderRadius = 5;
            this.btn_accountmanager_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_accountmanager_save.Location = new System.Drawing.Point(294, 216);
            this.btn_accountmanager_save.Name = "btn_accountmanager_save";
            this.btn_accountmanager_save.Size = new System.Drawing.Size(75, 30);
            this.btn_accountmanager_save.TabIndex = 5;
            this.btn_accountmanager_save.Text = "Save";
            this.btn_accountmanager_save.UseVisualStyleBackColor = true;
            this.btn_accountmanager_save.Click += new System.EventHandler(this.btn_accountmanager_save_Click);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(423, 273);
            this.Controls.Add(this.btn_accountmanager_save);
            this.Controls.Add(this.tb_accountmanager_password);
            this.Controls.Add(this.lbl_accountmanager_password);
            this.Controls.Add(this.tb_accountmanager_account);
            this.Controls.Add(this.lbl_accountmanager_account);
            this.Controls.Add(this.lbl_accountmanager_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 312);
            this.Name = "AccountManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_accountmanager_title;
        private System.Windows.Forms.Label lbl_accountmanager_account;
        private System.Windows.Forms.TextBox tb_accountmanager_account;
        private System.Windows.Forms.TextBox tb_accountmanager_password;
        private System.Windows.Forms.Label lbl_accountmanager_password;
        private ekayic.forms.elements.RoundedButton btn_accountmanager_save;
    }
}