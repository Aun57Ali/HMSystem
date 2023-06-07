using Hastane.DTO;
using Hastane.Entities;
using HastaneSistemi.BLL;
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
    public partial class PharmacistLogin : Form
    {
        public PharmacistLogin()
        {
            InitializeComponent();
        }

        PharmacistBLL pharmacistBLL = new PharmacistBLL();
        private void btnPharmacistLogin_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel();
            user.Username = txtUsername.Text;
            user.ppass = txtPassword.Text;

            Pharmacist loggedin = pharmacistBLL.Login(user);

            if (loggedin != null)
            {

                PharmacistOperationScreen frm = new PharmacistOperationScreen();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Pharmacist Login information is incorrect!");
            }
        }
    }
}
