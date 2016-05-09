using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC5_Entity.DataAccess.Models;
using ASP.NET_MVC5_Entity.DataAccess;


namespace Cadastro.Controllers
{
	public class HomeController : Controller
	{
    public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Aplicativo para Avaliação";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Contato";

			return View();
		}
	}
}