using System.Web;
using System.Web.Mvc;

namespace projet_de_fin_de_formation_ahz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
