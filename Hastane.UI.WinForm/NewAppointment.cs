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
    public partial class NewAppointment : Form
    {
        public NewAppointment()
        {
            InitializeComponent();
            dtNewAppointmentDate.MinDate = DateTime.Now.AddDays(1);
            lblAppointmentTimes.Visible = false;

        }

        public int doctorID;
        public int patientID;
        public int availableAppointmentID;
        public int analysisID;

        AppointmentBLL appointBLL = new AppointmentBLL();
        SessionBLL sesBLL = new SessionBLL();
        LabBLL labBLL = new LabBLL();
        Button[] buttons;
        List<int> fullSessions;


        public void CreateButton()
        {
            fullSessions = new List<int>();

            string appointmentdate = dtNewAppointmentDate.Value.ToString("yyyy-MM-dd");
            fullSessions = sesBLL.GetFullSessionID(appointmentdate, doctorID);

            buttons = new Button[14];
            Button btn;

            List<string> sessions = new List<string>();
            sessions = sesBLL.BringSessionNames();

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
            btnCreateNewAppointment.Enabled = true;
            if (clicked.BackColor == Color.DimGray)
            {
                clicked.BackColor = Color.White;
            }
            else
            {
                clicked.BackColor = Color.DimGray;
            }
        }

        private void btnNewAppointmentCall_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CreateButton();
            lblAppointmentTimes.Visible = true;
            btnCreateNewAppointment.Visible = true;
        }

        private void btnYeniRandevuOlustur_Click(object sender, EventArgs e)
        {
            string newAppointmentDate = dtNewAppointmentDate.Value.ToString("yyyy-MM-dd");


            Appointment appoint = new Appointment()
            {

                PatientID = patientID,
                DoctorID = doctorID,
                Appointmentdate = Convert.ToDateTime(newAppointmentDate),
                SessionID = Convert.ToInt32(clicked.Tag)

            };

            appoint.ID = appointBLL.CreateNewAppointment(appoint);

            Lab labb = new Lab()
            {

                labID = analysisID,
                AppointID = availableAppointmentID,
                NewAppointmentID = appoint.ID

            };

            int NumberRowsAffect = labBLL.CreateLab(labb);

            if (NumberRowsAffect > 0 && appoint.ID > 0)
            {
                MessageBox.Show("New Appointment successfully created");

            }
            else
            {
                MessageBox.Show("Failed to create new appointment");
            }

        }
    }
}
