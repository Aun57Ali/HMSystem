using HastaneSistemi.BLL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.UI.WinForm
{
    public partial class PharmacistOperationScreen : Form
    {
        public PharmacistOperationScreen()
        {
            InitializeComponent();
        }

        ListViewItem lvi;
        DetailBLL detailsBLL = new DetailBLL();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstMedName.Items.Clear();
            List<PrescriptionsDetail> details = new List<PrescriptionsDetail>();

            if (!string.IsNullOrWhiteSpace(mskTxtReceiptNumber.Text))
            {
                details = detailsBLL.PharmacistsInquire(Convert.ToInt32(mskTxtReceiptNumber.Text));

                foreach (PrescriptionsDetail item in details)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.MedicineName;
                    lvi.SubItems.Add(item.Note);
                    lstMedName.Items.Add(lvi);
                }

                mskTxtReceiptNumber.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("You cannot make inquiries without entering a prescription number.");
            }

        }

        private void PharmacistOperationScreen_Load(object sender, EventArgs e)
        {
            lblPharmacistName.Text = "WELCOME";
        }

        private void btnCNICSearch_Click(object sender, EventArgs e)
        {
            lstPrescriptionMed.Items.Clear();

            List<PrescriptionsDetail> rdetails = new List<PrescriptionsDetail>();

            if (!string.IsNullOrWhiteSpace(mskTxtCNIC.Text))
            {
                rdetails = detailsBLL.PatientPassedReceiept(mskTxtCNIC.Text);

                foreach (PrescriptionsDetail item in rdetails)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.PrescriptionNumber.ToString();
                    lvi.SubItems.Add(item.MedicineName);
                    lvi.SubItems.Add(item.Note);
                    lstPrescriptionMed.Items.Add(lvi);
                }
                mskTxtCNIC.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("You cannot make an inquiry without entering CNIC information.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
