namespace Hastane.UI.WinForm
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnPharmacistLogin = new System.Windows.Forms.Button();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientLogin.BackgroundImage")));
            this.btnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatientLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPatientLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatientLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPatientLogin.Location = new System.Drawing.Point(354, 173);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(138, 153);
            this.btnPatientLogin.TabIndex = 2;
            this.btnPatientLogin.Text = "Patient Login";
            this.btnPatientLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // btnPharmacistLogin
            // 
            this.btnPharmacistLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPharmacistLogin.BackgroundImage")));
            this.btnPharmacistLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPharmacistLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPharmacistLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPharmacistLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPharmacistLogin.Location = new System.Drawing.Point(180, 173);
            this.btnPharmacistLogin.Name = "btnPharmacistLogin";
            this.btnPharmacistLogin.Size = new System.Drawing.Size(138, 153);
            this.btnPharmacistLogin.TabIndex = 1;
            this.btnPharmacistLogin.Text = "Pharmacist Login";
            this.btnPharmacistLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPharmacistLogin.UseVisualStyleBackColor = true;
            this.btnPharmacistLogin.Click += new System.EventHandler(this.btnPharmacistLogin_Click);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorLogin.BackgroundImage")));
            this.btnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoctorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoctorLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctorLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDoctorLogin.Location = new System.Drawing.Point(2, 173);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(141, 153);
            this.btnDoctorLogin.TabIndex = 0;
            this.btnDoctorLogin.Text = "Doctor Login";
            this.btnDoctorLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 152);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(123, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.btnPharmacistLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOSPITAL APPOINTMENT CENTER";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnPharmacistLogin;
        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

