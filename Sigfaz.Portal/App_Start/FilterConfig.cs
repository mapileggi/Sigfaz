﻿using Ninject;
using Ninject.Web.Common.WebHost;
using System.Web;
using System.Web.Mvc;

namespace Sigfaz.Portal
{
    public class FilterConfig 
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}