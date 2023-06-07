using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hastane.DAL
{
    public class PharmacistDAL
    {

        SqlDataReader rdr;
        public List<Pharmacist> BringAllPharmacists()
        {
            List<Pharmacist> pharmacists = new List<Pharmacist>();
            SqlCommand cmd = new SqlCommand("sp_BringPharmacists", DBConnection.Conn);
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
                    Pharmacist pharmacist;
                    while (rdr.Read())
                    {
                        pharmacist = new Pharmacist()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Username = rdr["username"].ToString(),
                            Password = rdr["password"].ToString()

                        };
                        pharmacists.Add(pharmacist);
                    }
                }
                return pharmacists;
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
