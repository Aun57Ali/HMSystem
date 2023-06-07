using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class DetailBLL
    {
        DetailDAL detailDAL = new DetailDAL();


        public int AddMedicationPrescription(PrescriptionsDetail RecieptDetail)
        {
            return detailDAL.AddMedicationPrescription(RecieptDetail);
        }

        public List<PrescriptionsDetail> PharmacistsInquire(int prescriptionnumber)
        {

            return detailDAL.PharmacistsInquire(prescriptionnumber);
        }

        public List<PrescriptionsDetail> PatientPassedReceiept(string CNIC)
        {
            return detailDAL.PatientPassedReceipt(CNIC);
        }



    }
}
