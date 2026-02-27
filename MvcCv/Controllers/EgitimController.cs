using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;


namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        GenericRepository<TblEgitimlerim> repo =new GenericRepository<TblEgitimlerim>();
        // GET: Egitim
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        [HttpGet]
        public ActionResult EgitimEkle()
            
        {

            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEgitimlerim p ) 
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}