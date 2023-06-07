using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hastane.DAL
{
    public class HospitalDAL
    {
        SqlDataReader rdr;
        public List<Hospital> BringAllHospitals()
        {
            List<Hospital> hospitals = new List<Hospital>();
            SqlCommand cmd = new SqlCommand("sp_BringHospitals", DBConnection.Conn);
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
                    Hospital hospital;
                    while (rdr.Read())
                    {
                        hospital = new Hospital()
                        {
                            HosplCode = Convert.ToInt32(rdr["HospitalCode"]),
                            HospitalName = rdr["HospitalName"].ToString()

                        };
                        hospitals.Add(hospital);
                    }
                }
                return hospitals;
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

        public List<Hospital> BringClinics(int hospitalCode)
        {
            List<Hospital> clinics = new List<Hospital>();
            SqlCommand cmd = new SqlCommand("sp_BringClinics", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hospitalCode", hospitalCode);
            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Hospital Clinic;
                    while (rdr.Read())
                    {
                        Clinic = new Hospital()
                        {
                            ClinicName = rdr["ClinicName"].ToString()

                        };
                        clinics.Add(Clinic);
                    }
                }
                return clinics;
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

        public List<Doctor> FillDoctors(int hospitalCode, string clinicname)
        {
            List<Doctor> clinicdoctors = new List<Doctor>();
            SqlCommand cmd = new SqlCommand("sp_FillDoctors", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@clinicname", clinicname);
            cmd.Parameters.AddWithValue("@hospitalCode", hospitalCode);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Doctor clinicdoctor;
                    while (rdr.Read())
                    {
                        clinicdoctor = new Doctor()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            CName = rdr["Name"].ToString(),
                            Surname = rdr["Surname"].ToString()

                        };
                        clinicdoctors.Add(clinicdoctor);
                    }
                }
                return clinicdoctors;
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

    }
}
