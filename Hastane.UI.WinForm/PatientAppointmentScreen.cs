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
    public partial class PatientAppointmentScreen : Form
    {
        public PatientAppointmentScreen()
        {
            InitializeComponent();
            dtAppointmentDate.MinDate = DateTime.Now;
            btnCreateAppointment.Enabled = false;

        }

        PatientLoginRegister frm;
        public int patientID;
        public string patientSurname;

        Button[] buttons;
        List<int> fullSessions;

        public void CreatButton()
        {
            fullSessions = new List<int>();

            string appointmentdate = dtAppointmentDate.Value.ToString("yyyy-MM-dd");
            Doctor chosenDoctor = cmbDoctors.SelectedItem as Doctor;
            int doctorID = chosenDoctor.ID;
            fullSessions = sessionBLL.GetFullSessionID(appointmentdate, doctorID);
            buttons = new Button[14];
            Button btn;
            List<string> sessions = new List<string>();
            sessions = sessionBLL.BringSessionNames();

            for (int i = 1; i <= buttons.Length; i++)
            {
                btn = new Button();
                btn.FlatStyle = FlatStyle.Popup;
                btn.Width = 114;
                btn.Height = 30;
                btn.Tag = i;
                btn.Text = sessions[i - 1];
                btn.BackColor = Color.White;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
                if (fullSessions.Contains(i))
                {
                    btn.BackColor = Color.DimGray;
                    btn.Enabled = false;
                }
            }
        }

        Button clicked;
        private void Btn_Click(object sender, EventArgs e)
        {
            clicked = sender as Button;
            btnCreateAppointment.Enabled = true;
            if (clicked.BackColor == Color.DimGray)
            {
                clicked.BackColor = Color.White;
            }
            else
            {
                clicked.BackColor = Color.DimGray;
            }
        }

        HospitalBLL hospitalBLL = new HospitalBLL();
        SessionBLL sessionBLL = new SessionBLL();
        AppointmentBLL appointmentBLL = new AppointmentBLL();

        private void PatientAppointmentScreen_Load(object sender, EventArgs e)
        {
            btnCreateAppointment.Visible = false;
            lblAppointmentTimes.Visible = false;
            cmbHospitals.DataSource = hospitalBLL.BringAllHospitals();
            cmbHospitals.DisplayMember = "HospitalName";
            cmbHospitals.ValueMember = "HospitalCode";
        }

        private void cmbHospitals_SelectedIndexChanged(object sender, EventArgs e)
        {

            Hospital chosen = cmbHospitals.SelectedItem as Hospital;
            int hospitalcode = chosen.HosplCode;
            cmbClinics.DataSource = hospitalBLL.BringClinics(hospitalcode);
            cmbClinics.DisplayMember = "ClinicName";
        }

        private void cmbClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hospital chosenhospital = cmbHospitals.SelectedItem as Hospital;
            Hospital hospitalcode = cmbClinics.SelectedItem as Hospital;
            int hospitalCode = chosenhospital.HosplCode;
            string clinicName = hospitalcode.ClinicName;
            cmbDoctors.DataSource = hospitalBLL.FillDoctors(hospitalCode, clinicName);
            cmbDoctors.DisplayMember = "FullName";
            cmbDoctors.ValueMember = "ID";
        }

        public void btnCallAppointment_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            CreatButton();
            lblAppointmentTimes.Visible = true;
            btnCreateAppointment.Visible = true;
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string appointmentdate = dtAppointmentDate.Value.ToString("yyyy-MM-dd");

                Appointment appoint = new Appointment()
                {
                    PatientID = Convert.ToInt32(lblPatientName.Tag),
                    DoctorID = Convert.ToInt32(cmbDoctors.SelectedValue),
                    Appointmentdate = Convert.ToDateTime(appointmentdate),
                    SessionID = Convert.ToInt32(clicked.Tag)
                };

                bool record = appointmentBLL.CreateanAppointment(appoint);

                if (record)
                {
                    MessageBox.Show($"Appointment created\n\nHospitalName:{cmbHospitals.Text}\nClinic Name:{cmbClinics.Text}\nDoctor Name:{cmbDoctors.Text}\nDate:{appointmentdate}\nHour:{clicked.Text}", "Get Well Soon!!");
                    clicked = null;
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
                btnCallAppointment_Click(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("You cannot create an appointment without selecting a session.\nPlease select one of the available sessions.");

            }
        }

        private void randevularimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientAppointment frm = new PatientAppointment();
            frm.patientID = Convert.ToInt32(lblPatientName.Tag);
            frm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
