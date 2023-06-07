using Hastane.DAL;
using Hastane.DTO;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class DoctorBLL
    {

        DoctorDAL doctorDAL = new DoctorDAL();

        public List<Doctor> BringAlltheDoctors()
        {
            return doctorDAL.BringAlltheDoctors();
        }


        public Doctor Login(LoginModel user)
        {
            List<Doctor> alldoctors = this.BringAlltheDoctors();

            if (alldoctors == null)
            {
                return null;
            }

            foreach (Doctor item in alldoctors)
            {
                if (item.Username == user.Username && item.Password == user.ppass)
                {
                    return item;
                }
            }

            return null;
        }

        public int DoctorIDBring(string username)
        {
            return doctorDAL.DoctorIDBring(username);
        }

        public string DoctorNameBring(string username)
        {
            return doctorDAL.DoctorNameBring(username);
        }
    }
}
