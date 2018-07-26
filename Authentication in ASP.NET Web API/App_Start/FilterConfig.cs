using System.Web;
using System.Web.Mvc;

namespace Authentication_in_ASP.NET_Web_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
