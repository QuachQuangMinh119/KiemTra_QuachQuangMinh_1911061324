using System.Web;
using System.Web.Mvc;

namespace KiemTra_QuachQuangMinh_1911061324
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
