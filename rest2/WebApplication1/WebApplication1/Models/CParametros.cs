using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CParametros
    {
        public static string strConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}