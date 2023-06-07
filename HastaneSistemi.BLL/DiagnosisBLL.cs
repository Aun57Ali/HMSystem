using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class DiagnosisBLL
    {
        DiagnosisDAL diagnosisDAL = new DiagnosisDAL();

        public List<Diagnosis> BringAllDiagnoses()
        {
            return diagnosisDAL.BringAllDiagnoses();
        }



    }
}
