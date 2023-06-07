using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }

        public string PatientName { get; set; }

        public string PatientSurname { get; set; }

        public string HospitalName { get; set; }

        public string ClinicName { get; set; }

        public int DoctorID { get; set; }

        public string DoctorName { get; set; }

        public string DoctorSurname { get; set; }

        public DateTime Appointmentdate { get; set; }

        public int SessionID { get; set; }
        public string SessionTime { get; set; }

        public bool IsFull { get; set; }
        public bool didexam { get; set; }
        public string ExaminationNotes { get; set; }

    }
}
