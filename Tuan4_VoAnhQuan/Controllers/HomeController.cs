using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan4_VoAnhQuan.Models;

namespace Tuan4_VoAnhQuan.Controllers
{
    public class HomeController : Controller
    {
        MydataDataContext data = new MydataDataContext();
        
        public ActionResult Index(int ? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNum = page ?? 1;

            return View(all_sach.ToPagedList(pageNum, pageSize));
            
            
        }

        public ActionResult ListSach()
        {
            var all_sach = from ss in data.Saches select ss;
            return View(all_sach);
        }

        public ActionResult ListSach1()
        {
            ViewBag.Message = "Your contact page.";
            var all_sach = from ss in data.Saches select ss;

            return View(all_sach);
        }
    }
}