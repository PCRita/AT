﻿using System.Web;
using System.Web.Mvc;

namespace D02_UnityTest_MVC_Client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
