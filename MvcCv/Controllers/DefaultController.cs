using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {

            var degerler = db.TblHakkimda.ToList();

            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {

            var deneyimler = db.TblDeneyimlerim.ToList();

            return PartialView(deneyimler); // birden fazla tablo döndürmek için partialview kullandık (view tarafında birden fazla  bölme işlemi yapılacksa kullanılır)
        }

        public PartialViewResult Egitim()
        {

            var egitim = db.TblEgitimlerim.ToList();

            return PartialView(egitim); 
        }
        public PartialViewResult Yeteneklerim()
        {

            var yetenekler = db.TblYeteneklerim.ToList();

            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {

            var hobiler = db.TblHobilerim.ToList();

            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalar()
        {

            var sertifika = db.TblSertifikalarım.ToList();

            return PartialView(sertifika);
        }

        [HttpGet] // verileri .çeken 
        public PartialViewResult iletisim()
        {


            return PartialView();
        }

        [HttpPost] // butona basıldığında verileri yollayan
        public PartialViewResult iletisim(Tbliletisim t)
        {

            t.Tarih=  DateTime.Parse( DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            


            return PartialView();
        }
    }
}
