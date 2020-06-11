﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using coderush.AutoMapper;

namespace coderush
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Config automapper
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;


        }
    }
}
