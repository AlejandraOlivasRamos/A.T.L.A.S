﻿using System.Web;
using System.Web.Mvc;

namespace A.T.L.A.S
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
