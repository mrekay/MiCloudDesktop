namespace MiCloudDesktop
{
    partial class MiCloudDesktop
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiCloudDesktop));
            this.browser_main = new CefSharp.WinForms.ChromiumWebBrowser();
            this.pnl_main_controller = new ekayic.forms.elements.RoundedPanel();
            this.pb_main_icon = new System.Windows.Forms.PictureBox();
            this.btn_main_settings = new ekayic.forms.elements.RoundedButton();
            this.btn_main_reload = new ekayic.forms.elements.RoundedButton();
            this.btn_main_goforward = new ekayic.forms.elements.RoundedButton();
            this.btn_main_goback = new ekayic.forms.elements.RoundedButton();
            this.pnl_main_controller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // browser_main
            // 
            this.browser_main.ActivateBrowserOnCreation = false;
            this.browser_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_main.Location = new System.Drawing.Point(0, 0);
            this.browser_main.Name = "browser_main";
            this.browser_main.Size = new System.Drawing.Size(1384, 861);
            this.browser_main.TabIndex = 0;
            // 
            // pnl_main_controller
            // 
            this.pnl_main_controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pnl_main_controller.BorderRadius = 20;
            this.pnl_main_controller.Controls.Add(this.pb_main_icon);
            this.pnl_main_controller.Controls.Add(this.btn_main_settings);
            this.pnl_main_controller.Controls.Add(this.btn_main_reload);
            this.pnl_main_controller.Controls.Add(this.btn_main_goforward);
            this.pnl_main_controller.Controls.Add(this.btn_main_goback);
            this.pnl_main_controller.Location = new System.Drawing.Point(541, 791);
            this.pnl_main_controller.Name = "pnl_main_controller";
            this.pnl_main_controller.Size = new System.Drawing.Size(302, 42);
            this.pnl_main_controller.TabIndex = 1;
            // 
            // pb_main_icon
            // 
            this.pb_main_icon.BackgroundImage = global::MiCloudDesktop.Properties.Resources.xiaomi1;
            this.pb_main_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_main_icon.Location = new System.Drawing.Point(15, 9);
            this.pb_main_icon.Name = "pb_main_icon";
            this.pb_main_icon.Size = new System.Drawing.Size(24, 24);
            this.pb_main_icon.TabIndex = 4;
            this.pb_main_icon.TabStop = false;
            // 
            // btn_main_settings
            // 
            this.btn_main_settings.BackgroundImage = global::MiCloudDesktop.Properties.Resources.setting;
            this.btn_main_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_settings.BorderRadius = 5;
            this.btn_main_settings.FlatAppearance.BorderSize = 0;
            this.btn_main_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_settings.Location = new System.Drawing.Point(256, 5);
            this.btn_main_settings.Name = "btn_main_settings";
            this.btn_main_settings.Size = new System.Drawing.Size(32, 32);
            this.btn_main_settings.TabIndex = 3;
            this.btn_main_settings.UseVisualStyleBackColor = true;
            this.btn_main_settings.Click += new System.EventHandler(this.btn_main_settings_Click);
            // 
            // btn_main_reload
            // 
            this.btn_main_reload.BackgroundImage = global::MiCloudDesktop.Properties.Resources.reload;
            this.btn_main_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_reload.BorderRadius = 5;
            this.btn_main_reload.FlatAppearance.BorderSize = 0;
            this.btn_main_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_reload.Location = new System.Drawing.Point(135, 5);
            this.btn_main_reload.Name = "btn_main_reload";
            this.btn_main_reload.Size = new System.Drawing.Size(32, 32);
            this.btn_main_reload.TabIndex = 2;
            this.btn_main_reload.UseVisualStyleBackColor = true;
            this.btn_main_reload.Click += new System.EventHandler(this.btn_main_reload_Click);
            // 
            // btn_main_goforward
            // 
            this.btn_main_goforward.BackgroundImage = global::MiCloudDesktop.Properties.Resources.arrow_right;
            this.btn_main_goforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_goforward.BorderRadius = 5;
            this.btn_main_goforward.FlatAppearance.BorderSize = 0;
            this.btn_main_goforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_goforward.Location = new System.Drawing.Point(173, 5);
            this.btn_main_goforward.Name = "btn_main_goforward";
            this.btn_main_goforward.Size = new System.Drawing.Size(32, 32);
            this.btn_main_goforward.TabIndex = 1;
            this.btn_main_goforward.UseVisualStyleBackColor = true;
            this.btn_main_goforward.Click += new System.EventHandler(this.btn_main_goforward_Click);
            // 
            // btn_main_goback
            // 
            this.btn_main_goback.BackgroundImage = global::MiCloudDesktop.Properties.Resources.arrow_left;
            this.btn_main_goback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_goback.BorderRadius = 5;
            this.btn_main_goback.FlatAppearance.BorderSize = 0;
            this.btn_main_goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_goback.Location = new System.Drawing.Point(97, 5);
            this.btn_main_goback.Name = "btn_main_goback";
            this.btn_main_goback.Size = new System.Drawing.Size(32, 32);
            this.btn_main_goback.TabIndex = 0;
            this.btn_main_goback.UseVisualStyleBackColor = true;
            this.btn_main_goback.Click += new System.EventHandler(this.btn_main_goback_Click);
            // 
            // MiCloudDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.pnl_main_controller);
            this.Controls.Add(this.browser_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiCloudDesktop";
            this.Text = "MiCloudDesktop";
            this.Load += new System.EventHandler(this.MiCloudDesktop_Load);
            this.SizeChanged += new System.EventHandler(this.MiCloudDesktop_SizeChanged);
            this.pnl_main_controller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public CefSharp.WinForms.ChromiumWebBrowser browser_main;
        private ekayic.forms.elements.RoundedPanel pnl_main_controller;
        private ekayic.forms.elements.RoundedButton btn_main_goforward;
        private ekayic.forms.elements.RoundedButton btn_main_goback;
        private ekayic.forms.elements.RoundedButton btn_main_reload;
        private ekayic.forms.elements.RoundedButton btn_main_settings;
        private System.Windows.Forms.PictureBox pb_main_icon;
    }
}

