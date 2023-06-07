using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class LabBLL
    {
        LabDAL labDAL = new LabDAL();

        public int CreateLab(Lab lab)
        {
            return labDAL.CreateLab(lab);
        }




    }
}
