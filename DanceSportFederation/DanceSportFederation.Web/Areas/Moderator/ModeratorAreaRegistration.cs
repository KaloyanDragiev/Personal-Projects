using System.Web.Mvc;

namespace DanceSportFederation.Web.Areas.Home
{
    public class ModeratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Moderator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.MapMvcAttributeRoutes();
            context.MapRoute(
                "Moderator_default",
                "Moderator/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}