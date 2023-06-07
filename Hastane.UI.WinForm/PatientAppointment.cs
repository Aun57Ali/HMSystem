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
    public partial class PatientAppointment : Form
    {
        public PatientAppointment()
        {
            InitializeComponent();
        }


        AppointmentBLL appointBLL = new AppointmentBLL();
        public int patientID;

        private void PatientAppointment_Load(object sender, EventArgs e)
        {

            dgwPatientAppointments.DataSource = appointBLL.PatientAppointmentsView(patientID);
            dgwPatientAppointments.Columns["ID"].Visible = false;
            dgwPatientAppointments.Columns["PatientID"].Visible = false;
            dgwPatientAppointments.Columns["PatientName"].Visible = false;
            dgwPatientAppointments.Columns["PatientSurname"].Visible = false;
            dgwPatientAppointments.Columns["DoctorID"].Visible = false;
            dgwPatientAppointments.Columns["SessionID"].Visible = false;
            dgwPatientAppointments.Columns["Isitfull"].Visible = false;
            dgwPatientAppointments.Columns["DidAppointment"].Visible = false;
            dgwPatientAppointments.Columns["PrescriptionNotes"].Visible = false;
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgwPatientAppointments.SelectedRows)
            {
                int appointID = Convert.ToInt32(item.Cells["ID"].Value);
                appointBLL.CancelAppointment(appointID);
            }
            RefreshList();
        }

        private void RefreshList()
        {
            dgwPatientAppointments.DataSource = appointBLL.PatientAppointmentsView(patientID);
        }
    }
}
