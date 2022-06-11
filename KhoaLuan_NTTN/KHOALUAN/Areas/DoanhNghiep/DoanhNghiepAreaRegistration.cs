using System.Web.Mvc;

namespace KHOALUAN.Areas.DoanhNghiep
{
    public class DoanhNghiepAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DoanhNghiep";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DoanhNghiep_default",
                "DoanhNghiep/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}