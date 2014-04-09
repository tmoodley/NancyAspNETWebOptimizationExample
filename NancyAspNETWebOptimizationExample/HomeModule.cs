﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyAspNETWebOptimizationExample
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["Views/Home"];
            };
        }
    }
}