using Car_Agency.Domain.Abstract;
using Car_Agency.Domain.Concrete;
using Car_Agency.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Agency.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private CarsRepository carrepo;
        public HomeController(CarsRepository carparam)
        {
            carrepo = carparam;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Car car, HttpPostedFileBase upload)
        {
            EFDbContext context = new EFDbContext();
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Server.MapPath("~/Uploads"), upload.FileName);
                upload.SaveAs(path);
                car.Image = upload.FileName;
                context.cars.Add(car);
                context.SaveChanges();
                return RedirectToAction("Show");
            }
            else
                return View();
        }



        public ActionResult Show()
        {

            return View(carrepo.cars);
        }

        //public class TypesAndModels
        //{
        //   public IEnumerable<string> type { get; set; }
        //    public IEnumerable<string> model { get; set; }
        //}
        [HttpGet]
        public ActionResult Search()
        {


            return View(/*carrepo.cars*/);
        }
        [HttpPost]
        public ViewResult Search(Car car)
        {

            Car ca = (Car)carrepo.cars.Where(c => c.Type == car.Type && c.Model == car.Model && c.Price <= car.Price).FirstOrDefault();

            return View("ResultOfSearch", ca);

        }


        public ViewResult Installment()
        {
            return View();
        }
        [HttpPost]
        public JsonResult InstallmentCall(string model)
        {
            double price = carrepo.cars.Where(c => c.Model == model).Select(c => c.Price).FirstOrDefault();
            return Json(price, JsonRequestBehavior.AllowGet);
        }



        public ViewResult InstallerInfo()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InstallerInfo(InstallerInfo installer)
        {

            return View("SendWithEmail", installer);
        }
        public ViewResult SendWithEmail()
        {
            return View();
        }


        public ViewResult ContactUs()
        {
            return View();
        }
    }
}