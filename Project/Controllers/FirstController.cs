using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Project.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        /*public ActionResult Contact()
        {
            ViewBag.num = 10;
            return View();
        }*/
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.num = 10;
            return View();
        }
        [HttpPost]
        /*public ActionResult Contact(int x=0)    
        { 
            ViewBag.num = x;
            return View();
        }*/

        /*public ActionResult Contact(FormCollection form) 
        {
            ViewBag.Fname = form["fname"];
            ViewBag.Lname = form["lname"];
            ViewBag.ID = form["id"];
            ViewBag.Religion = form["religion"];

            return View();
        }*/
        public ActionResult Contact(string fname, string gender) 
        {
           ViewBag.Fname=fname;
            ViewBag.gender=gender;
            
            return View();
        }

































































    }
}