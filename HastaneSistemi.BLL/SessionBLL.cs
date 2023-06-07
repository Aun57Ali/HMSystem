using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class SessionBLL
    {
        SessionDAL sessionDAL = new SessionDAL();
        public List<Session> BringSessions(string appointmentdate, int doctorID)
        {
            return sessionDAL.BringSessions(appointmentdate, doctorID);
        }

        public List<string> BringSessionNames()
        {
            return sessionDAL.BringSessionNames();
        }

        public List<int> GetFullSessionID(string appointmentdate, int doctorID)
        {
            return sessionDAL.GetFullSessionID(appointmentdate, doctorID);
        }
    }
}
