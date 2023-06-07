using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Doctor
    {
        public int ID { get; set; }
        public string CName { get; set; }
        public string Surname { get; set; }

        private string fullName;

        public string FullName
        {
            get { return this.CName + " " + this.Surname; }

        }

        public string Branch { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Telephone { get; set; }
        private DateTime ddate;
        public DateTime dateb
        {
            get { return ddate; }
            set { ddate = value; }
        }
        public int HospitalID { get; set; }
    }
}
