using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class LabDAL
    {
        public int CreateLab(Lab lab)
        {

            SqlCommand cmd = new SqlCommand("sp_AddLab", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@labid", lab.labID);
            cmd.Parameters.AddWithValue("@appointmentID", lab.AppointID);
            cmd.Parameters.AddWithValue("@newAppointmentID", lab.NewAppointmentID);

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
