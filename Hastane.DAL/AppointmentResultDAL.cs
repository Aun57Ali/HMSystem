using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class AppointmentResultDAL
    {

        public int AddAppointmentResult(AppointmentResult appointmentResult)
        {

            SqlCommand cmd = new SqlCommand("sp_AddAppointmentResult", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointmentID", appointmentResult.AppointmentID);
            cmd.Parameters.AddWithValue("@didexamination", appointmentResult.Didexamination);
            cmd.Parameters.AddWithValue("@ExaminationNotes", appointmentResult.ExaminationNotes);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                DBConnection.Conn.Close();
            }

        }
    }
}
