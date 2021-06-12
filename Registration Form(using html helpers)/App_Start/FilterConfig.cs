using System.Web;
using System.Web.Mvc;

namespace Registration_Form_using_html_helpers_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
