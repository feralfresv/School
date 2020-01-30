using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;

namespace School.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Tabla()
        {
            using (SchoolEntities oTabla = new SchoolEntities())
            {
                var lTabla = from s in oTabla.School_Table select s;

                return View(lTabla.ToList());
            }            
        }
    }
}