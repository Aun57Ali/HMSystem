using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class AppointmentBLL
    {
        AppointmentDAL appointmentDAL = new AppointmentDAL();

        public bool CreateanAppointment(Appointment appointment)
        {
            int affectedLine = appointmentDAL.CreateanAppointment(appointment);

            if (affectedLine > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Appointment> PatientAppointmentsView(int PatientID)
        {

            return appointmentDAL.PatientAppointmentsView(PatientID);
        }

        public int CancelAppointment(int appointmentID)
        {
            return appointmentDAL.CancelAppointment(appointmentID);
        }

        public List<Appointment> DoctorAppointmentsView(int doctorID, string Todaydate)
        {
            return appointmentDAL.DoctorAppointmentsView(doctorID, Todaydate);
        }

        public int CreateNewAppointment(Appointment appoint)
        {
            return appointmentDAL.CreateNewAppointment(appoint);
        }



    }
}
