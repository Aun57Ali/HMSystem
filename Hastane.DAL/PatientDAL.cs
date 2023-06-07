using Hastane.Entities;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class PatientDAL
    {
        SqlDataReader rdr;
        public List<Patient> BringAllPatient()
        {
            List<Patient> patients = new List<Patient>();
            SqlCommand cmd = new SqlCommand("sp_BringPatients", DBConnection.Conn);
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
                    Patient patient;
                    while (rdr.Read())
                    {
                        patient = new Patient()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            PName = rdr["Name"].ToString(),
                            SName = rdr["Surname"].ToString(),
                            CNIC = rdr["CNIC"].ToString(),
                            Telephone = rdr["Telephone"].ToString(),
                            Email = rdr["Email"].ToString(),
                            Password = rdr["Password"].ToString()

                        };
                        patients.Add(patient);
                    }
                }
                return patients;
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

        public int PatientSave(Patient patient)
        {

            SqlCommand cmd = new SqlCommand("sp_PatientRegister", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", patient.PName);
            cmd.Parameters.AddWithValue("@surname", patient.SName);
            cmd.Parameters.AddWithValue("@cnic", patient.CNIC);
            cmd.Parameters.AddWithValue("@email", patient.Email);
            cmd.Parameters.AddWithValue("@password", patient.Password);
            cmd.Parameters.AddWithValue("@telephone", patient.Telephone);
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

        public int BringPatientID(string email)
        {
            SqlCommand cmd = new SqlCommand("sp_BringPatientID", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);

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

        public string PatientNameBring(string email)
        {
            SqlCommand cmd = new SqlCommand("sp_BringPatientName", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);

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
















        //public Hasta HastaIDGetir(string kullaniciAdi)
        //{
        //    Hasta hasta = new Hasta();
        //    SqlCommand cmd = new SqlCommand("sp_HastaIDGetir", DBConnection.Conn);

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);

        //    try
        //    {
        //        if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
        //        {
        //            DBConnection.Conn.Open();
        //        }
        //        rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows)
        //        {

        //            while (rdr.Read())
        //            {
        //                hasta = new Hasta()
        //                {
        //                    ID = Convert.ToInt32(rdr["ID"]),
        //                    Ad = rdr["Ad"].ToString(),
        //                    Soyad = rdr["Soyad"].ToString()

        //                };

        //            }
        //        }
        //        return hasta;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        rdr.Close();
        //        DBConnection.Conn.Close();
        //    }
        //}




















    }
}
