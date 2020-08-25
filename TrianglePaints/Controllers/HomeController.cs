using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace TrianglePaints.Controllers
{
    public class HomeController : Controller
    {
        private IDbConnection _db = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}