﻿using System.Web;
using System.Web.Mvc;

namespace D10_WebAPI_EF6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
