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
    public partial class DoctorOperationScreen : Form
    {

        public DoctorOperationScreen()
        {
            InitializeComponent();
        }

        AppointmentBLL appointmentBLL = new AppointmentBLL();
        DoctorBLL doctorBLL = new DoctorBLL();
        DiagnosisBLL diagnosisBLL = new DiagnosisBLL();
        LabResBLL analysisBLL = new LabResBLL();
        AppointmentResultBLL appointmentResultBLL = new AppointmentResultBLL();
        PrescriptionBLL medBLL = new PrescriptionBLL();

        public int doctorID;
        public string Todaydate;

        private void dgwDaysAppointments_Click(object sender, EventArgs e)
        {
            
        }

        private void DoctorOperationScreen_Load(object sender, EventArgs e)
        {
            

            doctorID = Convert.ToInt32(lblDoctorSurname.Tag);

            Todaydate = DateTime.Now.ToString("yyyy-MM-dd");

            RefreshList();

            cmbLab.Enabled = false;
            btnCreateNewAppointment.Enabled = false;


            #region Filling the Diagnoses
            cmbDiagnostics.DataSource = diagnosisBLL.BringAllDiagnoses();
            cmbDiagnostics.DisplayMember = "Name";
            cmbDiagnostics.ValueMember = "ID";
            #endregion


            #region Filling Lab Types
            cmbLab.DataSource = analysisBLL.BringAllTypesofLabs();
            cmbLab.DisplayMember = "Name";
            cmbLab.ValueMember = "ID";
            #endregion

        }

        private void RefreshList()
        {
            dgwDaysAppointments.DataSource = appointmentBLL.DoctorAppointmentsView(doctorID, Todaydate);

            dgwDaysAppointments.Columns["ID"].Visible = false;
            dgwDaysAppointments.Columns["PatientID"].Visible = false;
            dgwDaysAppointments.Columns["DoctorID"].Visible = false;
            dgwDaysAppointments.Columns["DoctorName"].Visible = false;
            dgwDaysAppointments.Columns["DoctorSurname"].Visible = false;
            dgwDaysAppointments.Columns["SessionID"].Visible = false;
            dgwDaysAppointments.Columns["HospitalName"].Visible = false;
            dgwDaysAppointments.Columns["ClinicName"].Visible = false;
            dgwDaysAppointments.Columns["IsItFull"].Visible = false;
            dgwDaysAppointments.Columns["DidInspectionHappen"].Visible = false;
            dgwDaysAppointments.Columns["InspectionNotes"].Visible = false;

        }

        private void dgwDaysAppointments_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string PatientName = dgwDaysAppointments.CurrentRow.Cells["PatientName"].Value.ToString();
            string PatientSurname = dgwDaysAppointments.CurrentRow.Cells["PatientSurname"].Value.ToString();


            txtPatientName.Text = PatientName + " " + PatientSurname;
        }

        private void chkPatientNot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPatientNot.Checked)
            {
                cmbDiagnostics.Enabled = false;
                chkDiagnosticFailed.Enabled = false;

                btnCreateReceipt.Enabled = false;
            }
            else
            {
                cmbDiagnostics.Enabled = true;
                chkDiagnosticFailed.Enabled = true;

                btnCreateReceipt.Enabled = true;

            }
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {

            try
            {
                Diagnosis diagnosis = cmbDiagnostics.SelectedItem as Diagnosis;

                Prescriptions prescriptions = new Prescriptions()
                {
                    PatientID = Convert.ToInt32(dgwDaysAppointments.CurrentRow.Cells["PatientID"].Value),
                    DoctorID = Convert.ToInt32(lblDoctorSurname.Tag),
                    DiagnosisID = diagnosis.ID,
                    Date = DateTime.Now,

                };

                prescriptions.PrescriptionNumber = medBLL.AddtoPrescription(prescriptions);


                if (prescriptions.PrescriptionNumber > 0)
                {
                    MessageBox.Show("Receipt Created");
                    RefreshList();
                }
                else
                {
                    MessageBox.Show("Failed To Create");
                }

                Medication frm = new Medication();
                frm.txtReceiptNumber.Text = prescriptions.PrescriptionNumber.ToString();
                frm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("You cannot create a prescription without choosing an appointment.");
            }
        }

        private void chkDiagnosticFailed_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkDiagnosticFailed.Checked)
            {
                chkPatientNot.Enabled = false;
                cmbLab.Enabled = true;
                btnCreateNewAppointment.Enabled = true;
                cmbDiagnostics.Enabled = false;
                btnCreateReceipt.Enabled = false;
                btnConfirm.Enabled = false;
            }
            else
            {
                chkPatientNot.Enabled = true;
                cmbLab.Enabled = false;
                btnCreateNewAppointment.Enabled = false;
                cmbDiagnostics.Enabled = true;
                btnCreateReceipt.Enabled = true;
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int meetingID = Convert.ToInt32(dgwDaysAppointments.CurrentRow.Cells["ID"].Value);
                bool situation;

                if (chkPatientNot.Checked)
                {
                    situation = false;

                }

                else
                {
                    situation = true;
                }


                AppointmentResult appointmentResult = new AppointmentResult()
                {
                    AppointmentID = meetingID,
                    Didexamination = situation,
                    ExaminationNotes = txtExaminationNotes.Text

                };

                bool record = appointmentResultBLL.AddAppointmentResult(appointmentResult);

                if (record)
                {
                    MessageBox.Show("Registration Successful");

                    if (chkPatientNot.Checked)
                    {
                        RefreshList();

                    }

                }
                else
                {
                    MessageBox.Show("The record could not be added.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You cannot confirm without choosing an appointment.");
            }
        }

        private void btnCreateNewAppointment_Click(object sender, EventArgs e)
        {
            LabRes analysis = cmbLab.SelectedItem as LabRes;
            NewAppointment frm = new NewAppointment();

            frm.doctorID = this.doctorID;
            frm.patientID = Convert.ToInt32(dgwDaysAppointments.CurrentRow.Cells["PatientID"].Value);
            frm.analysisID = analysis.ID;
            frm.availableAppointmentID = Convert.ToInt32(dgwDaysAppointments.CurrentRow.Cells["ID"].Value);
            RefreshList();
            frm.ShowDialog();
        }

        private void GBInspectionProcedures_Enter(object sender, EventArgs e)
        {

        }

        private void dgwDaysAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
