﻿using System.Web;
using System.Web.Mvc;

namespace OnlineStore_ADMIN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
