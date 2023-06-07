using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class AppointmentResultBLL
    {

        AppointmentResultDAL appointmentResultDAL = new AppointmentResultDAL();

        public bool AddAppointmentResult(AppointmentResult appointmentResult)
        {

            int affectedLine = appointmentResultDAL.AddAppointmentResult(appointmentResult);

            if (affectedLine > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
