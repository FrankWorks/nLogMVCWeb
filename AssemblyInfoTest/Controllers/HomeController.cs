using Core;
using DataAccess;
using Infrastructure.VO;
//using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace AssemblyInfoTest.Controllers
{
    public class HomeController : Controller
    {
       // private static Logger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            ViewBag.CoreAssemblyInfo = SomeCoreClass.GetAssemblyInfo();
            ViewBag.DataAccessAssemblyInfo = SomeDataAccessClass.GetAssemblyInfo();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string webAsseblyInfo = string.Format("Full Name = \"{0}\"; Informational Version = \"{1}\"",
                                    assembly.FullName, FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion);
            ViewBag.WebAssemblyInfo = webAsseblyInfo;
            //logger.Trace("Trace--You have visited the Index view");
            //logger.Debug("Debug--You have visited the Index view");
            //logger.Info("Info--You have visited the Index view");

            ProcessVO vo = new ProcessVO();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //logger.Info("You have visited the About view");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //logger.Info("You have visited the Contact view");
            return View();
        }
    }
}