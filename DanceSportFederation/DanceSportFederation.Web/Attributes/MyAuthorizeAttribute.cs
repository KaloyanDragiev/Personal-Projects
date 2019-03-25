using DanceSportFederation.Data;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanceSportFederation.Web.Attributes
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var roles = this.Roles.Split(',');
            if (filterContext.HttpContext.Request.IsAuthenticated && !roles.Any(filterContext.HttpContext.User.IsInRole))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "/Views/Shared/Unauthorized.cshtml"
                };
            }
            else
	        {

                base.HandleUnauthorizedRequest(filterContext);
            }

        }
    }
}