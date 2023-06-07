namespace Hastane.UI.WinForm
{
    partial class PatientAppointmentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppointmentScreen));
            this.lblAppointmentTimes = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCallAppointment = new System.Windows.Forms.Button();
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.cmbClinics = new System.Windows.Forms.ComboBox();
            this.cmbHospitals = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevularimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppointmentTimes
            // 
            this.lblAppointmentTimes.AutoSize = true;
            this.lblAppointmentTimes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentTimes.Location = new System.Drawing.Point(524, 46);
            this.lblAppointmentTimes.Name = "lblAppointmentTimes";
            this.lblAppointmentTimes.Size = new System.Drawing.Size(140, 20);
            this.lblAppointmentTimes.TabIndex = 0;
            this.lblAppointmentTimes.Text = "Appointment Hours";
            // 
            // lblHastaAdSoyad
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientName.Location = new System.Drawing.Point(18, 46);
            this.lblPatientName.Name = "lblHastaAdSoyad";
            this.lblPatientName.Size = new System.Drawing.Size(171, 20);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name Goes Here";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCallAppointment);
            this.groupBox1.Controls.Add(this.dtAppointmentDate);
            this.groupBox1.Controls.Add(this.cmbDoctors);
            this.groupBox1.Controls.Add(this.cmbClinics);
            this.groupBox1.Controls.Add(this.cmbHospitals);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupBox1.Location = new System.Drawing.Point(22, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Procedures";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Choose Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Clinic:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date:";
            // 
            // btnCallAppointment
            // 
            this.btnCallAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCallAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCallAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCallAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnCallAppointment.Image")));
            this.btnCallAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallAppointment.Location = new System.Drawing.Point(214, 205);
            this.btnCallAppointment.Name = "btnCallAppointment";
            this.btnCallAppointment.Size = new System.Drawing.Size(157, 47);
            this.btnCallAppointment.TabIndex = 2;
            this.btnCallAppointment.Text = "Search";
            this.btnCallAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCallAppointment.UseVisualStyleBackColor = false;
            this.btnCallAppointment.Click += new System.EventHandler(this.btnCallAppointment_Click);
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAppointmentDate.Location = new System.Drawing.Point(141, 51);
            this.dtAppointmentDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(325, 27);
            this.dtAppointmentDate.TabIndex = 1;
            this.dtAppointmentDate.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Location = new System.Drawing.Point(140, 164);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(325, 28);
            this.cmbDoctors.TabIndex = 0;
            // 
            // cmbClinics
            // 
            this.cmbClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinics.FormattingEnabled = true;
            this.cmbClinics.Location = new System.Drawing.Point(140, 126);
            this.cmbClinics.Name = "cmbClinics";
            this.cmbClinics.Size = new System.Drawing.Size(325, 28);
            this.cmbClinics.TabIndex = 0;
            this.cmbClinics.SelectedIndexChanged += new System.EventHandler(this.cmbClinics_SelectedIndexChanged);
            // 
            // cmbHospitals
            // 
            this.cmbHospitals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHospitals.FormattingEnabled = true;
            this.cmbHospitals.Location = new System.Drawing.Point(141, 88);
            this.cmbHospitals.Name = "cmbHospitals";
            this.cmbHospitals.Size = new System.Drawing.Size(325, 28);
            this.cmbHospitals.TabIndex = 0;
            this.cmbHospitals.SelectedIndexChanged += new System.EventHandler(this.cmbHospitals_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(528, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 252);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAppointment.Image")));
            this.btnCreateAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAppointment.Location = new System.Drawing.Point(560, 345);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(186, 64);
            this.btnCreateAppointment.TabIndex = 7;
            this.btnCreateAppointment.Text = "Create";
            this.btnCreateAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAppointment.UseVisualStyleBackColor = false;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevularimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevularimToolStripMenuItem
            // 
            this.randevularimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.randevularimToolStripMenuItem.Name = "randevularimToolStripMenuItem";
            this.randevularimToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.randevularimToolStripMenuItem.Text = "My appointments";
            this.randevularimToolStripMenuItem.Click += new System.EventHandler(this.randevularimToolStripMenuItem_Click);
            // 
            // PatientAppointmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblAppointmentTimes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientAppointmentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Procedures";
            this.Load += new System.EventHandler(this.PatientAppointmentScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentTimes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.ComboBox cmbClinics;
        private System.Windows.Forms.ComboBox cmbHospitals;
        private System.Windows.Forms.Button btnCallAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreateAppointment;
        public System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevularimToolStripMenuItem;
    }
}