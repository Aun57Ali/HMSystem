using Hastane.DTO;
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
    public partial class frmDoktorGirisEkrani : Form
    {

        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }

        DoctorBLL doctorBLL = new DoctorBLL();
        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel();
            user.Username = txtUserName.Text;
            user.ppass = txtPassword.Text;

            Doctor loggedin = doctorBLL.Login(user);

            if (loggedin != null)
            {

                DoctorOperationScreen frm = new DoctorOperationScreen();

                frm.lblDoctorSurname.Text = "WELCOME SN. " + doctorBLL.DoctorNameBring(user.Username);

                frm.lblDoctorSurname.Tag = doctorBLL.DoctorIDBring(user.Username);

                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Doctor Login information is incorrect!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
