using ASP.NET_MVC5_Entity.DataAccess.UnitOfWork;
using ASP.NET_MVC5_Entity.DataAccess.Models;
using ASP.NET_MVC5_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC5_Entity.Controllers
{
	public class AlunosController : Controller
	{

		private UnitOfWork uow = new UnitOfWork();

		// GET: Alunos/Details/5
		public ActionResult Details(int id)
		{
			//factory
			var aluno = uow.GetRepository<Aluno>().GetById(id);
			return View(aluno);
		}

		// GET: Alunos/Create

		public ActionResult Create()
		{
			AlunosVM alunosVm = new AlunosVM() { alunos = uow.GetRepository<Aluno>().All() };

			return View(alunosVm);
		}


		// POST: Alunos/Create
		[HttpPost]
		public ActionResult Create(AlunosVM alunos)
		{
			try
			{
				if (ModelState.IsValid)
				{
					uow.GetRepository<Aluno>().Add(alunos.aluno);
					uow.Save();
					var alunosCol = new AlunosVM() { alunos = uow.GetRepository<Aluno>().All() };
					return View(alunosCol);
				}
			}
			catch (Exception exc)
			{
				return View("CustomError", exc);
			}
			return RedirectToAction("Create");
		}

		// GET: Alunos/Edit/5
		public ActionResult Edit(int id)
		{
			var aluno = uow.GetRepository<Aluno>().GetById(id);
			return View(aluno);
		}

		// POST: Alunos/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, Aluno aluno)
		{
			try
			{
				if (ModelState.IsValid)
				{
					uow.GetRepository<Aluno>().Update(aluno);
					uow.Save();
				}
			}
			catch (Exception exc)
			{
				return View("CustomError", exc);
			}
			return RedirectToAction("Create");

		}

		// GET: Alunos/Delete/5
		public ActionResult Delete(int id)
		{
			var aluno = uow.GetRepository<Aluno>().GetById(id);
			return View(aluno);
		}

		// POST: Alunos/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, Aluno aluno)
		{
			try
			{
				uow.GetRepository<Aluno>().DeleteById(id);
				uow.Save();
				return RedirectToAction("Create");
			}
			catch (Exception exc)
			{
				return View("CustomError", exc);
			}
		}


		//WebApi PAGE - AJAX
		public ActionResult List()
		{
			return View();
		}

	}
}