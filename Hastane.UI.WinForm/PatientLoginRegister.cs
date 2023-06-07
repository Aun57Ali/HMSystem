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
    public partial class PatientLoginRegister : Form
    {
        public PatientLoginRegister()
        {
            InitializeComponent();
        }

        //PatientBLL patBLL = new PatientBLL();
        PatientBLL patientBLL= new PatientBLL();

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.PName = txtName.Text;
            patient.SName = txtSurname.Text;
            patient.CNIC = mskTxtCNIC.Text;
            patient.Telephone = mskTxtTelephone.Text;
            patient.Email = txtEmail.Text;
            patient.Password = txtPass.Text;

            bool record = patientBLL.PatientRegister(patient);

            if (record)
            {
                MessageBox.Show("Patient successfully enrolled");
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tb = item as TextBox;
                        tb.Clear();
                    }

                    if (item is MaskedTextBox)
                    {
                        MaskedTextBox mtb = item as MaskedTextBox;
                        mtb.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: Could not add patient");
            }
        }


        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel();
            user.Username = txtUsername.Text;
            user.ppass = txtPassword.Text;

            Patient loggedin = patientBLL.Login(user);

            if (loggedin != null)
            {
                PatientAppointmentScreen frm = new PatientAppointmentScreen();
                frm.lblPatientName.Text = "Welcome " + patientBLL.PatientNameBring(user.Username);
                frm.lblPatientName.Tag = patientBLL.BringPatientID(user.Username);
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your login information is incorrect.\nIf you are not a registered, please register.");
            }
        }

        private void txtUyeSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUyeTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUyeSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskTxtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
