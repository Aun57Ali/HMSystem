namespace Hastane.UI.WinForm
{
    partial class NewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAppointment));
            this.dtNewAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnNewAppointmentCall = new System.Windows.Forms.Button();
            this.btnCreateNewAppointment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAppointmentTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtNewAppointmentDate
            // 
            this.dtNewAppointmentDate.Location = new System.Drawing.Point(77, 60);
            this.dtNewAppointmentDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtNewAppointmentDate.Name = "dtNewAppointmentDate";
            this.dtNewAppointmentDate.Size = new System.Drawing.Size(208, 20);
            this.dtNewAppointmentDate.TabIndex = 0;
            this.dtNewAppointmentDate.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // btnNewAppointmentCall
            // 
            this.btnNewAppointmentCall.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNewAppointmentCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewAppointmentCall.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewAppointmentCall.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAppointmentCall.Image")));
            this.btnNewAppointmentCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAppointmentCall.Location = new System.Drawing.Point(77, 106);
            this.btnNewAppointmentCall.Name = "btnNewAppointmentCall";
            this.btnNewAppointmentCall.Size = new System.Drawing.Size(157, 47);
            this.btnNewAppointmentCall.TabIndex = 3;
            this.btnNewAppointmentCall.Text = "Search Appointment";
            this.btnNewAppointmentCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewAppointmentCall.UseVisualStyleBackColor = false;
            this.btnNewAppointmentCall.Click += new System.EventHandler(this.btnNewAppointmentCall_Click);
            // 
            // btnCreateNewAppointment
            // 
            this.btnCreateNewAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateNewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewAppointment.Image")));
            this.btnCreateNewAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewAppointment.Location = new System.Drawing.Point(324, 318);
            this.btnCreateNewAppointment.Name = "btnCreateNewAppointment";
            this.btnCreateNewAppointment.Size = new System.Drawing.Size(186, 64);
            this.btnCreateNewAppointment.TabIndex = 10;
            this.btnCreateNewAppointment.Text = "Create an Appointment";
            this.btnCreateNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNewAppointment.UseVisualStyleBackColor = false;
            this.btnCreateNewAppointment.Click += new System.EventHandler(this.btnYeniRandevuOlustur_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 252);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblRandevuSaatleri
            // 
            this.lblAppointmentTimes.AutoSize = true;
            this.lblAppointmentTimes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentTimes.Location = new System.Drawing.Point(320, 19);
            this.lblAppointmentTimes.Name = "lblRandevuSaatleri";
            this.lblAppointmentTimes.Size = new System.Drawing.Size(140, 20);
            this.lblAppointmentTimes.TabIndex = 8;
            this.lblAppointmentTimes.Text = "Appointment Hours";
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 404);
            this.Controls.Add(this.btnCreateNewAppointment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblAppointmentTimes);
            this.Controls.Add(this.btnNewAppointmentCall);
            this.Controls.Add(this.dtNewAppointmentDate);
            this.Name = "NewAppointment";
            this.Text = "New Appointment Assignment Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNewAppointmentDate;
        private System.Windows.Forms.Button btnNewAppointmentCall;
        private System.Windows.Forms.Button btnCreateNewAppointment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAppointmentTimes;
    }
}