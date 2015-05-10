using System.Web;
using System.Web.Mvc;

namespace MVC5Course
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());//新增錯誤處理網頁
        }
    }
}
