using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class PrescriptionDAL
    {

        public int AddtoPrescription(Prescriptions receipt)
        {

            SqlCommand cmd = new SqlCommand("sp_CreateReceipt", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@patientID", receipt.PatientID);
            cmd.Parameters.AddWithValue("@doctorID", receipt.DoctorID);
            cmd.Parameters.AddWithValue("@diagnosisID", receipt.DiagnosisID);
            cmd.Parameters.AddWithValue("@date", receipt.Date);

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
    }
}
