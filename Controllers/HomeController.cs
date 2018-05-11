using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project02.Models;


namespace Project02.Controllers
{
    public class HomeController : Controller
    {

       DatabaseContext db = new DatabaseContext();

        public IActionResult Index()
        {
            ViewBag.list = db.Table01.ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


         // Create
        [HttpPost]
        public IActionResult Create(TestObject to)
        {
            db.Table01.Add(to);
            db.SaveChanges();
            return View("~/Views/Home/Index.cshtml");
        }

         // Update
        [HttpPost]
        public IActionResult Update(int id, string text)
        {
            
            TestObject testObject = new TestObject(){
                TestObjectId = id,
                Field01 = text
            }; 
            db.Update(testObject);
            db.SaveChanges();
            ViewBag.list = db.Table01.ToList();
            return View("~/Views/Home/Index.cshtml");
        }


        // Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            
            TestObject testObject = new TestObject(){
                TestObjectId = id,
            }; 
            db.Table01.Remove(testObject);
            db.SaveChanges();
            ViewBag.list = db.Table01.ToList();
            return View("~/Views/Home/Index.cshtml");
        }

    }
}
