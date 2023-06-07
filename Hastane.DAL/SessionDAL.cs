using Hastane.Entities;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.DAL
{
    public class SessionDAL
    {
        SqlDataReader rdr;
        SqlDataReader rdr2;


        public List<Session> BringSessions(string appointmentdate, int doctorID)
        {
            List<Session> sessions = new List<Session>();
            SqlCommand cmd = new SqlCommand("sp_CheckSessions", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointmentdate", appointmentdate);
            cmd.Parameters.AddWithValue("@doctorID", doctorID);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Session session;
                    while (rdr.Read())
                    {
                        session = new Session()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            SessionName = rdr["SessionName"].ToString()

                        };
                        sessions.Add(session);
                    }
                }
                return sessions;
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

        public List<string> BringSessionNames()
        {
            List<string> sess = new List<string>();
            SqlCommand cmd = new SqlCommand("sp_BringSessionNames", DBConnection.Conn);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Session sessions;
                    while (rdr.Read())
                    {
                        sessions = new Session()
                        {

                            SessionName = rdr["sessionName"].ToString()
                        };
                        
                        sess.Add(sessions.SessionName);
                    }
                }
                return sess;
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

        public List<int> GetFullSessionID(string appointmentdate2, int doctorID2)
        {
            List<int> fullSessions = new List<int>();
            SqlCommand cmd = new SqlCommand("[dbo].[sp_BringFullSessions]", DBConnection.Conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointmentdate", appointmentdate2);
            cmd.Parameters.AddWithValue("@doctorID", doctorID2);


            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Session session;
                    while (rdr.Read())
                    {
                        session = new Session()
                        {

                            ID = Convert.ToInt32(rdr["SessionID"])
                        };
                                              
                        fullSessions.Add(session.ID);
                    }
                }
                return fullSessions;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
