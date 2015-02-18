using System.Web;
using System.Web.Mvc;

namespace JMCC_Employee_Track_Record
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}