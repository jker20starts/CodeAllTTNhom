﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coderush.Areas.TTNhom_QLTTHPT.Models;

namespace coderush.Areas.TTNhom_QLTTHPT.Controllers
{
    public class LopController : Controller
    {
        QuanLyTTHPTConText db = new QuanLyTTHPTConText();

        // GET: TTNhom_QLTTHPT/Lop
        public ActionResult Index()
        {
            List<LOP> res = db.LOPs.ToList();
            return View(res);
        }
    }
}