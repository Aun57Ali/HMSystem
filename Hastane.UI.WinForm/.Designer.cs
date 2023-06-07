namespace Hastane.UI.WinForm
{
    partial class PharmacistOperationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistOperationScreen));
            this.lblPharmacistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMedName = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCNICSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPrescriptionMed = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtReceiptNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTxtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEczaciAdSoyad
            // 
            this.lblPharmacistName.AutoSize = true;
            this.lblPharmacistName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPharmacistName.Location = new System.Drawing.Point(6, 19);
            this.lblPharmacistName.Name = "lblEczaciAdSoyad";
            this.lblPharmacistName.Size = new System.Drawing.Size(0, 20);
            this.lblPharmacistName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Receipt Number:";
            // 
            // lstMedName
            // 
            this.lstMedName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMedName.GridLines = true;
            this.lstMedName.HideSelection = false;
            this.lstMedName.Location = new System.Drawing.Point(10, 104);
            this.lstMedName.Name = "lstMedName";
            this.lstMedName.Size = new System.Drawing.Size(293, 160);
            this.lstMedName.TabIndex = 3;
            this.lstMedName.UseCompatibleStateImageBehavior = false;
            this.lstMedName.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Notes";
            this.columnHeader2.Width = 175;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(191, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCNICSearch
            // 
            this.btnCNICSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCNICSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCNICSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCNICSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCNICSearch.Image")));
            this.btnCNICSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCNICSearch.Location = new System.Drawing.Point(107, 61);
            this.btnCNICSearch.Name = "btnCNICSearch";
            this.btnCNICSearch.Size = new System.Drawing.Size(112, 36);
            this.btnCNICSearch.TabIndex = 7;
            this.btnCNICSearch.Text = "Search";
            this.btnCNICSearch.UseVisualStyleBackColor = false;
            this.btnCNICSearch.Click += new System.EventHandler(this.btnCNICSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Token";
            // 
            // lstPrescriptionMed
            // 
            this.lstPrescriptionMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPrescriptionMed.GridLines = true;
            this.lstPrescriptionMed.HideSelection = false;
            this.lstPrescriptionMed.Location = new System.Drawing.Point(18, 103);
            this.lstPrescriptionMed.Name = "lstPrescriptionMed";
            this.lstPrescriptionMed.Size = new System.Drawing.Size(358, 160);
            this.lstPrescriptionMed.TabIndex = 8;
            this.lstPrescriptionMed.UseCompatibleStateImageBehavior = false;
            this.lstPrescriptionMed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prescription Number";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Notes";
            this.columnHeader5.Width = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTxtReceiptNumber);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lstMedName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 288);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription Inquiry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mskTxtReceiptNumber
            // 
            this.mskTxtReceiptNumber.Location = new System.Drawing.Point(194, 32);
            this.mskTxtReceiptNumber.Mask = "00000";
            this.mskTxtReceiptNumber.Name = "mskTxtReceiptNumber";
            this.mskTxtReceiptNumber.Size = new System.Drawing.Size(109, 27);
            this.mskTxtReceiptNumber.TabIndex = 11;
            this.mskTxtReceiptNumber.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTxtCNIC);
            this.groupBox2.Controls.Add(this.lstPrescriptionMed);
            this.groupBox2.Controls.Add(this.btnCNICSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(400, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 286);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History Screen";
            // 
            // mskTxtCNIC
            // 
            this.mskTxtCNIC.Location = new System.Drawing.Point(107, 31);
            this.mskTxtCNIC.Mask = "00000-00000000-0";
            this.mskTxtCNIC.Name = "mskTxtCNIC";
            this.mskTxtCNIC.Size = new System.Drawing.Size(112, 27);
            this.mskTxtCNIC.TabIndex = 11;
            // 
            // frmEczaciIslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPharmacistName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEczaciIslemEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquiry Screen";
            this.Load += new System.EventHandler(this.PharmacistOperationScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPharmacistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMedName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCNICSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstPrescriptionMed;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskTxtCNIC;
        private System.Windows.Forms.MaskedTextBox mskTxtReceiptNumber;
    }
}