﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dream.Shop.Web.Areas.Admin.Controllers
{
    public class GoodsController : ManageControllerBase<good_service,goods>
    {
        
        public ActionResult Index()
        {
            return View();
        }

    }
}
