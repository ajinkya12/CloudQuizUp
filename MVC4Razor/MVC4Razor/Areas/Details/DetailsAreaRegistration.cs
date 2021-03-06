﻿using System.Web.Mvc;

namespace MVC4Razor.Areas.Details
{
    public class DetailsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Details";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Details_default",
                "Details/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
