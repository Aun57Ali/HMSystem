using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class AppointmentResult
    {
        public int ID { get; set; }

        public int AppointmentID { get; set; }

        public bool Didexamination { get; set; }

        public string ExaminationNotes { get; set; }


    }
}
