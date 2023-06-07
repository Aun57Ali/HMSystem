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
    public class AppointmentDAL
    {

        SqlDataReader rdr;

        public int CreateanAppointment(Appointment appointment)
        {

            SqlCommand cmd = new SqlCommand("sp_CreateAppointment", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@patientID", appointment.PatientID);
            cmd.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
            cmd.Parameters.AddWithValue("@appointmentdate", appointment.Appointmentdate);
            cmd.Parameters.AddWithValue("@sessionID", appointment.SessionID);

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

        public List<Appointment> PatientAppointmentsView(int patientID)
        {
            List<Appointment> appointments = new List<Appointment>();
            SqlCommand cmd = new SqlCommand("sp_PatientAppointmentsView", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@patientID", patientID);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Appointment appointment;
                    while (rdr.Read())
                    {
                        appointment = new Appointment()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            PatientID = Convert.ToInt32(rdr["PatientID"]),
                            HospitalName = rdr["HospitalName"].ToString(),
                            ClinicName = rdr["ClinicName"].ToString(),
                            DoctorName = rdr["Name"].ToString(),
                            DoctorSurname = rdr["Surname"].ToString(),
                            Appointmentdate = Convert.ToDateTime(rdr["Date"].ToString()),
                            SessionTime = rdr["SessionName"].ToString()

                        };
                        appointments.Add(appointment);
                    }
                }
                return appointments;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }

        public int CancelAppointment(int appointmentID)
        {
            SqlCommand cmd = new SqlCommand("sp_CancelAppointment", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointmentID", appointmentID);

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

        public List<Appointment> DoctorAppointmentsView(int doctorID, string Todaydate)
        {
            List<Appointment> doctorappointments = new List<Appointment>();
            SqlCommand cmd = new SqlCommand("sp_DoctorAppointmentsView", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@doctorID", doctorID);
            cmd.Parameters.AddWithValue("@todaydate", Todaydate);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Appointment appointment;
                    while (rdr.Read())
                    {
                        appointment = new Appointment()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            PatientID = Convert.ToInt32(rdr["PatientID"]),
                            PatientName = rdr["Name"].ToString(),
                            PatientSurname = rdr["Surname"].ToString(),
                            Appointmentdate = Convert.ToDateTime(rdr["Date"].ToString()),
                            SessionTime = rdr["SessionName"].ToString()

                        };
                        doctorappointments.Add(appointment);
                    }
                }
                return doctorappointments;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }
        public int CreateNewAppointment(Appointment randevu)
        {
            SqlCommand cmd = new SqlCommand("sp_Create NewAppointment", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hpatientID", randevu.PatientID);
            cmd.Parameters.AddWithValue("@doctorID", randevu.DoctorID);
            cmd.Parameters.AddWithValue("@date", randevu.Appointmentdate);
            cmd.Parameters.AddWithValue("@sessionID", randevu.SessionID);

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
