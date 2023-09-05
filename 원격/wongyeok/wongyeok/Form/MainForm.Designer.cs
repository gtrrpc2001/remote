
namespace wongyeok
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.tbox_controller_ip = new System.Windows.Forms.TextBox();
            this.btn_setting = new DevComponents.DotNetBar.ButtonX();
            this.btn_ok = new DevComponents.DotNetBar.ButtonX();
            this.timer_send_img = new System.Windows.Forms.Timer(this.components);
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(147, 11);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.Size = new System.Drawing.Size(239, 21);
            this.tbox_ip.TabIndex = 0;
            // 
            // tbox_controller_ip
            // 
            this.tbox_controller_ip.Enabled = false;
            this.tbox_controller_ip.Location = new System.Drawing.Point(147, 56);
            this.tbox_controller_ip.Name = "tbox_controller_ip";
            this.tbox_controller_ip.ReadOnly = true;
            this.tbox_controller_ip.Size = new System.Drawing.Size(239, 21);
            this.tbox_controller_ip.TabIndex = 1;
            // 
            // btn_setting
            // 
            this.btn_setting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_setting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_setting.Location = new System.Drawing.Point(415, 11);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(95, 23);
            this.btn_setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_setting.TabIndex = 2;
            this.btn_setting.Text = "설정하기";
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(415, 56);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 23);
            this.btn_ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "원격 제어 허용";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // timer_send_img
            // 
            this.timer_send_img.Tick += new System.EventHandler(this.timer_send_img_Tick);
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelX1.Location = new System.Drawing.Point(12, 11);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(111, 18);
            this.LabelX1.TabIndex = 3;
            this.LabelX1.Text = "원격 호스트 주소 :";
            // 
            // LabelX2
            // 
            this.LabelX2.AutoSize = true;
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelX2.ForeColor = System.Drawing.Color.Gold;
            this.LabelX2.Location = new System.Drawing.Point(0, 56);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(123, 18);
            this.LabelX2.TabIndex = 4;
            this.LabelX2.Text = "원격 컨트롤러 주소 :";
            // 
            // noti
            // 
            this.noti.Text = "notifyIcon1";
            this.noti.Visible = true;
            this.noti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noti_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 94);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.tbox_controller_ip);
            this.Controls.Add(this.tbox_ip);
            this.Name = "MainForm";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.TextBox tbox_controller_ip;
        private DevComponents.DotNetBar.ButtonX btn_setting;
        private DevComponents.DotNetBar.ButtonX btn_ok;
        private System.Windows.Forms.Timer timer_send_img;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        private System.Windows.Forms.NotifyIcon noti;
    }
}