using Hastane.DTO;
using Hastane.Entities;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        DoctorBLL doktorBLL = new DoctorBLL();

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
            frm.ShowDialog();
        }

        private void btnPharmacistLogin_Click(object sender, EventArgs e)
        {
            PharmacistLogin frm = new PharmacistLogin();
            frm.ShowDialog();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            PatientLoginRegister frm = new PatientLoginRegister();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

