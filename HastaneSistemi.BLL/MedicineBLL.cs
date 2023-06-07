using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class MedicineBLL
    {
        MedicineDAL medicineDAL = new MedicineDAL();

        public List<Medicine> BringAllMedicines()
        {
            return medicineDAL.BringAllMedicines();
        }


    }
}
