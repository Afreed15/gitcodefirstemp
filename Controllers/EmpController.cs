using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppcodeFirstpra.Data;
using WebAppcodeFirstpra.Models;

namespace WebAppcodeFirstpra.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp 
        WebAppcodeFirstpraContext db = new WebAppcodeFirstpraContext();
        public ActionResult Index()
        {
           
            return View(db.Emps.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(Emp obj)
        {
            Emp list = new Emp();
            list.Add(obj);
            return View("Index",db.Emps.ToList());
        }

    }
}