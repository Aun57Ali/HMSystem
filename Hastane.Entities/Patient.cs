using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Patient
    {
        public int ID { get; set; }
        public string PName { get; set; }
        public string SName { get; set; }

        private string fullName;

        public string FullName
        {
            get { return this.PName + " " + this.SName; }

        }

        public string CNIC { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        private DateTime ddate;
        public DateTime dateb
        {
            get { return ddate; }
            set { ddate = value; }
        }


    }
}
