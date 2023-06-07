using Hastane.DAL;
using Hastane.DTO;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class PatientBLL
    {
        PatientDAL patientDAL = new PatientDAL();


        public List<Patient> BringAllPatient()
        {
            return patientDAL.BringAllPatient();
        }
        public Patient Login(LoginModel user)
        {

            List<Patient> allPatients = this.BringAllPatient();

            if (allPatients == null)
            {
                return null;
            }

            foreach (Patient item in allPatients)
            {
                if (item.Email == user.Username && item.Password == user.ppass)
                {
                    return item;
                }
            }

            return null;
        }

        public bool PatientRegister(Patient patient)
        {
            if (!string.IsNullOrWhiteSpace(patient.PName) && !string.IsNullOrWhiteSpace(patient.SName)
                && !string.IsNullOrWhiteSpace(patient.CNIC) && !string.IsNullOrWhiteSpace(patient.Telephone)
                && !string.IsNullOrWhiteSpace(patient.Email) && !string.IsNullOrWhiteSpace(patient.Password) 
                && patient.Password.Length>=8)
            {
                int affectedLine = patientDAL.PatientSave(patient);

                if (affectedLine > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public int BringPatientID(string username)
        {
            return patientDAL.BringPatientID(username);
        }

        public string PatientNameBring(string username)
        {
            return patientDAL.PatientNameBring(username);

        }


    }
}
