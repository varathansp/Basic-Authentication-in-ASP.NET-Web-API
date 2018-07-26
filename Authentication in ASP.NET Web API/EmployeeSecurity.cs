using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Authentication_in_ASP.NET_Web_API
{
    public class EmployeeSecurity
    {
        public static bool Login(string user, string pass)
        {
            using (dbsampleEntities entitis = new dbsampleEntities())
            {
                return entitis.Users.Any(us=>us.UserName.Equals(user,StringComparison.OrdinalIgnoreCase)&& us.Password==pass);
            }
        }
    }
}