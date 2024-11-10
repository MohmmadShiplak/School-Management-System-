using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public  class clsPaymentsData
    {

        public static DataTable GetAllPayments() => clsDataAccessHelper.All("SP_GetAllPayments");
    }
}
