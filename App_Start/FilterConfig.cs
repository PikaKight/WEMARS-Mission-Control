using System.Web;
using System.Web.Mvc;

namespace WEMARS_Mission_Control
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
