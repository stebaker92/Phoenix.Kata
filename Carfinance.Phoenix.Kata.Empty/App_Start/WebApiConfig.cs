﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Carfinance.Phoenix.Kata.Empty
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}