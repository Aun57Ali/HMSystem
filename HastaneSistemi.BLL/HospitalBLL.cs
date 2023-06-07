using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class HospitalBLL
    {
        HospitalDAL hospitalDAL = new HospitalDAL();
        public List<Hospital> BringAllHospitals()
        {
            return hospitalDAL.BringAllHospitals();
        }

        public List<Hospital> BringClinics(int hospitalcode)
        {
            return hospitalDAL.BringClinics(hospitalcode);
        }

        public List<Doctor> FillDoctors(int hospitalcode, string clinicName)
        {
            return hospitalDAL.FillDoctors(hospitalcode, clinicName);
        }
    }
}
