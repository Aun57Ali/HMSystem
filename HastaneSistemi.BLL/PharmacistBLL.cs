using Hastane.DAL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class PharmacistBLL
    {
        PharmacistDAL pharmacistDal = new PharmacistDAL();

        public List<Pharmacist> BringAllPharmacists()
        {
            return pharmacistDal.BringAllPharmacists();
        }
        public Pharmacist Login(LoginModel user)
        {
            List<Pharmacist> allPharmacists = this.BringAllPharmacists();

            if (allPharmacists == null)
            {
                return null;
            }

            foreach (Pharmacist item in allPharmacists)
            {
                if (item.Username == user.Username && item.Password == user.ppass)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
