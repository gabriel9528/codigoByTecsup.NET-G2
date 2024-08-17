using System.Web;
using System.Web.Mvc;

namespace AdoNet_SP_AspNetFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
