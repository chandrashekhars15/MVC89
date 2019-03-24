using System.Web;
using System.Web.Mvc;

namespace MVC89_CS_TempDataExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
