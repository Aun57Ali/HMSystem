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
    public class DetailDAL
    {

        public int AddMedicationPrescription(PrescriptionsDetail receiptdetail)
        {

            SqlCommand cmd = new SqlCommand("sp_AddMedicationtoPrescription", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@prescriptionnumber", receiptdetail.PrescriptionNumber);
            cmd.Parameters.AddWithValue("@medicineID", receiptdetail.MedicineID);
            cmd.Parameters.AddWithValue("@Note", receiptdetail.Note);

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

        SqlDataReader rdr;
        public List<PrescriptionsDetail> PharmacistsInquire(int prescriptionnumber)
        {
            List<PrescriptionsDetail> receiptDetails = new List<PrescriptionsDetail>();
            SqlCommand cmd = new SqlCommand("sp_PharmacistMedicineInquiry", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@prescriptionnumber", prescriptionnumber);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    PrescriptionsDetail receiptDetail;
                    while (rdr.Read())
                    {
                        receiptDetail = new PrescriptionsDetail()
                        {
                            MedicineName = rdr["Name"].ToString(),
                            Note = rdr["Note"].ToString()

                        };
                        receiptDetails.Add(receiptDetail);
                    }
                }
                return receiptDetails;
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

        public List<PrescriptionsDetail> PatientPassedReceipt(string CNIC)
        {
            List<PrescriptionsDetail> receiptdetail = new List<PrescriptionsDetail>();
            SqlCommand cmd = new SqlCommand("sp_PatientPassed", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CNIC", CNIC);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    PrescriptionsDetail receiptDetail;
                    while (rdr.Read())
                    {
                        receiptDetail = new PrescriptionsDetail()
                        {
                            PrescriptionNumber = Convert.ToInt32(rdr["PrescriptionNumber"]),
                            MedicineName = rdr["Name"].ToString(),
                            Note = rdr["Notes"].ToString()

                        };
                        receiptdetail.Add(receiptDetail);
                    }
                }
                return receiptdetail;
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
