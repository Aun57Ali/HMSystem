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
    public partial class Medication : Form
    {
        public Medication()
        {
            InitializeComponent();
        }

        MedicineBLL MedicineBLL = new MedicineBLL();
        DetailBLL DetailBLL = new DetailBLL();

        private void Medication_Load(object sender, EventArgs e)
        {
            #region Filling Medications
            cmbMed.DataSource = MedicineBLL.BringAllMedicines();
            cmbMed.DisplayMember = "Name";
            cmbMed.ValueMember = "ID";
            #endregion

        }
        ListViewItem lvi;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicine medi = cmbMed.SelectedItem as Medicine;

            lvi = new ListViewItem();

            PrescriptionsDetail RDetail = new PrescriptionsDetail()
            {
                PrescriptionNumber = Convert.ToInt32(txtReceiptNumber.Text),
                MedicineID = medi.ID,
                Note = txtMedicineNotes.Text
            };

            int NumberRowsAff = DetailBLL.AddMedicationPrescription(RDetail);

            if (NumberRowsAff > 0)
            {
                MessageBox.Show("Adding medication successful");

                lvi.Text = cmbMed.Text;
                lvi.SubItems.Add(txtMedicineNotes.Text);
                lstMed.Items.Add(lvi);
                txtMedicineNotes.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Wrong");
            }

        }
    }
}
