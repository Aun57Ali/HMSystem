using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class LabResBLL
    {
        LabResDAL labresDAL = new LabResDAL();

        public List<LabRes> BringAllTypesofLabs()
        {
            return labresDAL.BringAllTypesofLabs();
        }


    }
}
