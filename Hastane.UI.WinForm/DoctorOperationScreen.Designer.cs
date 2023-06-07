namespace Hastane.UI.WinForm
{
    partial class DoctorOperationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorOperationScreen));
            this.lblDoctorSurname = new System.Windows.Forms.Label();
            this.dgwDaysAppointments = new System.Windows.Forms.DataGridView();
            this.chkPatientNot = new System.Windows.Forms.CheckBox();
            this.GBInspectionProcedures = new System.Windows.Forms.GroupBox();
            this.btnCreateNewAppointment = new System.Windows.Forms.Button();
            this.chkDiagnosticFailed = new System.Windows.Forms.CheckBox();
            this.btnCreateReceipt = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDiagnostics = new System.Windows.Forms.ComboBox();
            this.txtExaminationNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDaysAppointments)).BeginInit();
            this.GBInspectionProcedures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoktorUnvanAdSoyad
            // 
            this.lblDoctorSurname.AutoSize = true;
            this.lblDoctorSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoctorSurname.Location = new System.Drawing.Point(12, 9);
            this.lblDoctorSurname.Name = "lblDoktorUnvanAdSoyad";
            this.lblDoctorSurname.Size = new System.Drawing.Size(368, 20);
            this.lblDoctorSurname.TabIndex = 0;
            this.lblDoctorSurname.Text = "DOCTOR PROCESSES WILL BE DONE ON THIS SCREEN";
            // 
            // dgwDaysAppointments
            // 
            this.dgwDaysAppointments.AllowUserToAddRows = false;
            this.dgwDaysAppointments.AllowUserToDeleteRows = false;
            this.dgwDaysAppointments.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwDaysAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDaysAppointments.Location = new System.Drawing.Point(17, 37);
            this.dgwDaysAppointments.Name = "dgwDaysAppointments";
            this.dgwDaysAppointments.ReadOnly = true;
            this.dgwDaysAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDaysAppointments.Size = new System.Drawing.Size(426, 391);
            this.dgwDaysAppointments.TabIndex = 2;
            this.dgwDaysAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDaysAppointments_CellContentClick);
            this.dgwDaysAppointments.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwDaysAppointments_RowHeaderMouseDoubleClick);
            // 
            // chkPatientNot
            // 
            this.chkPatientNot.AutoSize = true;
            this.chkPatientNot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkPatientNot.Location = new System.Drawing.Point(184, 46);
            this.chkPatientNot.Name = "chkPatientNot";
            this.chkPatientNot.Size = new System.Drawing.Size(110, 24);
            this.chkPatientNot.TabIndex = 3;
            this.chkPatientNot.Text = "Didn\'t Came";
            this.chkPatientNot.UseVisualStyleBackColor = true;
            this.chkPatientNot.CheckedChanged += new System.EventHandler(this.chkPatientNot_CheckedChanged);
            // 
            // GBInspectionProcedures
            // 
            this.GBInspectionProcedures.Controls.Add(this.btnCreateNewAppointment);
            this.GBInspectionProcedures.Controls.Add(this.chkDiagnosticFailed);
            this.GBInspectionProcedures.Controls.Add(this.btnCreateReceipt);
            this.GBInspectionProcedures.Controls.Add(this.btnConfirm);
            this.GBInspectionProcedures.Controls.Add(this.cmbLab);
            this.GBInspectionProcedures.Controls.Add(this.label5);
            this.GBInspectionProcedures.Controls.Add(this.cmbDiagnostics);
            this.GBInspectionProcedures.Controls.Add(this.txtExaminationNotes);
            this.GBInspectionProcedures.Controls.Add(this.label4);
            this.GBInspectionProcedures.Controls.Add(this.label2);
            this.GBInspectionProcedures.Controls.Add(this.txtPatientName);
            this.GBInspectionProcedures.Controls.Add(this.label1);
            this.GBInspectionProcedures.Controls.Add(this.chkPatientNot);
            this.GBInspectionProcedures.Location = new System.Drawing.Point(496, 37);
            this.GBInspectionProcedures.Name = "GBInspectionProcedures";
            this.GBInspectionProcedures.Size = new System.Drawing.Size(352, 398);
            this.GBInspectionProcedures.TabIndex = 4;
            this.GBInspectionProcedures.TabStop = false;
            this.GBInspectionProcedures.Text = "Inspection Screen";
            this.GBInspectionProcedures.Enter += new System.EventHandler(this.GBInspectionProcedures_Enter);
            // 
            // btnCreateNewAppointment
            // 
            this.btnCreateNewAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateNewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewAppointment.Image")));
            this.btnCreateNewAppointment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateNewAppointment.Location = new System.Drawing.Point(21, 288);
            this.btnCreateNewAppointment.Name = "btnCreateNewAppointment";
            this.btnCreateNewAppointment.Size = new System.Drawing.Size(107, 97);
            this.btnCreateNewAppointment.TabIndex = 15;
            this.btnCreateNewAppointment.Text = "Create New Appointment";
            this.btnCreateNewAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateNewAppointment.UseVisualStyleBackColor = false;
            this.btnCreateNewAppointment.Click += new System.EventHandler(this.btnCreateNewAppointment_Click);
            // 
            // chkDiagnosticFailed
            // 
            this.chkDiagnosticFailed.AutoSize = true;
            this.chkDiagnosticFailed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDiagnosticFailed.Location = new System.Drawing.Point(159, 105);
            this.chkDiagnosticFailed.Name = "chkDiagnosticFailed";
            this.chkDiagnosticFailed.Size = new System.Drawing.Size(129, 24);
            this.chkDiagnosticFailed.TabIndex = 14;
            this.chkDiagnosticFailed.Text = "Not Diagnosed";
            this.chkDiagnosticFailed.UseVisualStyleBackColor = true;
            this.chkDiagnosticFailed.CheckedChanged += new System.EventHandler(this.chkDiagnosticFailed_CheckedChanged_1);
            // 
            // btnCreateReceipt
            // 
            this.btnCreateReceipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateReceipt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateReceipt.Image")));
            this.btnCreateReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReceipt.Location = new System.Drawing.Point(136, 288);
            this.btnCreateReceipt.Name = "btnCreateReceipt";
            this.btnCreateReceipt.Size = new System.Drawing.Size(174, 44);
            this.btnCreateReceipt.TabIndex = 9;
            this.btnCreateReceipt.Text = "Create";
            this.btnCreateReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateReceipt.UseVisualStyleBackColor = false;
            this.btnCreateReceipt.Click += new System.EventHandler(this.btnCreateReceipt_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(136, 341);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(174, 44);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Inspection Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbLab
            // 
            this.cmbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(136, 136);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(174, 21);
            this.cmbLab.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lab Test";
            // 
            // cmbDiagnostics
            // 
            this.cmbDiagnostics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostics.FormattingEnabled = true;
            this.cmbDiagnostics.Location = new System.Drawing.Point(136, 77);
            this.cmbDiagnostics.Name = "cmbDiagnostics";
            this.cmbDiagnostics.Size = new System.Drawing.Size(174, 21);
            this.cmbDiagnostics.TabIndex = 1;
            // 
            // txtExaminationNotes
            // 
            this.txtExaminationNotes.Location = new System.Drawing.Point(136, 183);
            this.txtExaminationNotes.Multiline = true;
            this.txtExaminationNotes.Name = "txtExaminationNotes";
            this.txtExaminationNotes.Size = new System.Drawing.Size(174, 81);
            this.txtExaminationNotes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inspection Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diagnosis:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(136, 19);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(174, 20);
            this.txtPatientName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // DoctorOperationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 456);
            this.Controls.Add(this.GBInspectionProcedures);
            this.Controls.Add(this.dgwDaysAppointments);
            this.Controls.Add(this.lblDoctorSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorOperationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspection";
            this.Load += new System.EventHandler(this.DoctorOperationScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDaysAppointments)).EndInit();
            this.GBInspectionProcedures.ResumeLayout(false);
            this.GBInspectionProcedures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwDaysAppointments;
        public System.Windows.Forms.Label lblDoctorSurname;
        private System.Windows.Forms.CheckBox chkPatientNot;
        private System.Windows.Forms.GroupBox GBInspectionProcedures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExaminationNotes;
        private System.Windows.Forms.ComboBox cmbDiagnostics;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateReceipt;
        private System.Windows.Forms.CheckBox chkDiagnosticFailed;
        private System.Windows.Forms.Button btnCreateNewAppointment;
    }
}