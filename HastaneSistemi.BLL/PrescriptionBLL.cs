using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class PrescriptionBLL
    {
        PrescriptionDAL prescriptionDAL = new PrescriptionDAL();

        public int AddtoPrescription(Prescriptions prescription)
        {
            return prescriptionDAL.AddtoPrescription(prescription);
        }

    }
}
