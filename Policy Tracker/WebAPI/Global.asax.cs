﻿using System.Web.Http;
using System.Web.Http.Validation.Providers;
using System.Web.Mvc;

namespace WebAPI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.EnsureInitialized();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}