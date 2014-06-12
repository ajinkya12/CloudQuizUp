using System.Web.Mvc;

namespace MVC4Razor.Areas.ButtonDemo
{
    public class ButtonDemoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ButtonDemo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ButtonDemo_default",
                "ButtonDemo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
