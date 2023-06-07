using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class PrescriptionsDetail
    {
        public int PrescriptionNumber { get; set; }
        public int MedicineID { get; set; }

        public string MedicineName { get; set; }
        public string Note { get; set; }


    }
}
