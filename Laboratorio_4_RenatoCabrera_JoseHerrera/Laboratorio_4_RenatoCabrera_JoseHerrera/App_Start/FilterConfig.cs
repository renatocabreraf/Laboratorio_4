using System.Web;
using System.Web.Mvc;

namespace Laboratorio_4_RenatoCabrera_JoseHerrera
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
