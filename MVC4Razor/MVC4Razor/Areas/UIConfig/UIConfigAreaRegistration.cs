using System.Web.Mvc;

namespace MVC4Razor.Areas.UIConfig
{
    public class UIConfigAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "UIConfig";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "UIConfig_default",
                "UIConfig/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
