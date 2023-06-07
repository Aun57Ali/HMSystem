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
    public class DiagnosisDAL
    {
        SqlDataReader rdr;
        public List<Diagnosis> BringAllDiagnoses()
        {
            List<Diagnosis> diagnoses = new List<Diagnosis>();
            SqlCommand cmd = new SqlCommand("sp_GetDiagnoses", DBConnection.Conn);
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
                    Diagnosis diagnosis;
                    while (rdr.Read())
                    {
                        diagnosis = new Diagnosis()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Name = rdr["Name"].ToString()

                        };
                        diagnoses.Add(diagnosis);
                    }
                }
                return diagnoses;
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
