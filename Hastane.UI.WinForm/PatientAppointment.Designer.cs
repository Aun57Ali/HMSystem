namespace Hastane.UI.WinForm
{
    partial class PatientAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientAppointment));
            this.dgwPatientAppointments = new System.Windows.Forms.DataGridView();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatientAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPatientAppointments
            // 
            this.dgwPatientAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwPatientAppointments.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwPatientAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatientAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwPatientAppointments.Location = new System.Drawing.Point(0, 0);
            this.dgwPatientAppointments.Name = "dgwPatientAppointments";
            this.dgwPatientAppointments.ReadOnly = true;
            this.dgwPatientAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPatientAppointments.Size = new System.Drawing.Size(774, 297);
            this.dgwPatientAppointments.TabIndex = 0;
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAppointment.Image")));
            this.btnCancelAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAppointment.Location = new System.Drawing.Point(250, 317);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(197, 83);
            this.btnCancelAppointment.TabIndex = 1;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // PatientAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 422);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.dgwPatientAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My appointments";
            this.Load += new System.EventHandler(this.PatientAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatientAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPatientAppointments;
        private System.Windows.Forms.Button btnCancelAppointment;
    }
}