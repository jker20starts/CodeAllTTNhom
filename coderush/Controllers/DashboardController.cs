﻿using coderush.Areas.TTNhom_QLThuVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Dashboardv1()
        {
            // QL_NhanSu

            // QL_ThuVien
            DBQLTVContext dbQLTV = new DBQLTVContext();
            var totalBook = (from b in dbQLTV.Saches
                             select b).Count();

            var totalCategory = (from c in dbQLTV.TheLoais
                                 select c).Count();

            var totalPublishingCompany = (from c in dbQLTV.NhaXuatBans
                                 select c).Count();

            var totalAuthor = (from a in dbQLTV.TacGias
                               select a).Count();

            var totalReader = (from r in dbQLTV.DocGias
                               select r).Count();

            var totalBG = (from bg in dbQLTV.MuonTraSaches
                           select bg).Count();

            var alreadyBG = (from bg in dbQLTV.MuonTraSaches
                             where bg.DaTra == true
                             select bg).Count();

            var yetBG = (from bg in dbQLTV.MuonTraSaches
                         where bg.DaTra == false
                         select bg).Count();

            ViewBag.TotalBook = totalBook;
            ViewBag.TotalCategory = totalCategory;
            ViewBag.TotalPublishingCompany = totalPublishingCompany;
            ViewBag.TotalAuthor = totalAuthor;
            ViewBag.TotalReader = totalReader;
            ViewBag.TotalBG = totalBG;
            ViewBag.AlreadyBG = alreadyBG;
            ViewBag.YetBG = yetBG;

            // QL_Kho

            // QL_KhachSan

            // QL_TruongTHPT

            return View();
        }

        public ActionResult Dashboardv2()
        {
            return View();
        }
    }
}