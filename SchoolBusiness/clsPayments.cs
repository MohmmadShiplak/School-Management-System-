using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public  class clsPayments
    {

    public static DataTable GetAllPayments()=>clsPaymentsData.GetAllPayments();

    }
}
