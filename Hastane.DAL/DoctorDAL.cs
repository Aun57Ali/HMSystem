using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HastaneSistemi.Entities;

namespace Hastane.DAL
{
    public class DoctorDAL
    {

        SqlDataReader rdr;
        public List<Doctor> BringAlltheDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            SqlCommand cmd = new SqlCommand("sp_BringDoctors", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Doctor doctor;
                    while (rdr.Read())
                    {
                        doctor = new Doctor()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Username = rdr["Username"].ToString(),
                            Password = rdr["Password"].ToString()

                        };
                        doctors.Add(doctor);
                    }
                }
                return doctors;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }


        public int DoctorIDBring(string username)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorIDBring", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return Convert.ToInt32(cmd.ExecuteScalar());
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


        public string DoctorNameBring(string username)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorNameBring", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                return (-1).ToString();
            }
            finally
            {
                DBConnection.Conn.Close();
            }

        }

    }
}
