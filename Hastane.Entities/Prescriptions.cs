using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Prescriptions
    {
        public int PrescriptionNumber { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int DiagnosisID { get; set; }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

    }
}
