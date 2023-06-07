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
    public class MedicineDAL
    {
        SqlDataReader rdr;
        public List<Medicine> BringAllMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            SqlCommand cmd = new SqlCommand("sp_BringMedicines", DBConnection.Conn);
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
                    Medicine medicine;
                    while (rdr.Read())
                    {
                        medicine = new Medicine()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Name = rdr["Name"].ToString()

                        };
                        medicines.Add(medicine);
                    }
                }
                return medicines;
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
