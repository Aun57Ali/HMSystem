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
    public class LabResDAL
    {
        SqlDataReader rdr;
        public List<LabRes> BringAllTypesofLabs()
        {
            List<LabRes> labtypes = new List<LabRes>();
            SqlCommand cmd = new SqlCommand("sp_BringTests", DBConnection.Conn);
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
                    LabRes labTypes;
                    while (rdr.Read())
                    {
                        labTypes = new LabRes()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Code = rdr["Code"].ToString(),
                            Name = rdr["Name"].ToString()

                        };
                        labtypes.Add(labTypes);
                    }
                }
                return labtypes;
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
