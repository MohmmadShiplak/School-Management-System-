using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace SchoolDataAccess
{
    public class clsSettings
    {
        public static string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
           // "Server=.;database=School Project;User Id=sa;Password=sa123456;";
    }
}
