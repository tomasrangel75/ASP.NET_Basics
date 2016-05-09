using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiRepository.DataAccess.Models;
using ApiRepository.DataAccess.ServiceLayer;
using System.Web.Http.Cors;

namespace ApiRepository.Controllers
{
		[EnableCors(origins: "http://localhost:27919", headers: "*", methods: "*")]
	public class AlunosController : ApiController
	{
		private IService svc = new Service();

		// GET: api/AlunosApi
		public IHttpActionResult Get()
		{
			var alunos = svc.Alunos.All();
			return Ok(alunos);
		}

		// GET: api/AlunosApi/5
		//[ResponseType(typeof(Aluno))]
		//public IHttpActionResult Get(int id)
		//{
		//	Aluno aluno = svc.Alunos.GetById(id);
		//	if (aluno == null)
		//	{
		//		return NotFound();
		//	}

		//	return Ok(aluno);
			
		//}

		// PUT: api/AlunosApi/5
		[HttpPut]
		[ResponseType(typeof(void))]
		public IHttpActionResult Update(int id, Aluno aluno)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != aluno.Id)
			{
				return BadRequest();
			}

			svc.Alunos.Update(aluno);

			try
			{
				svc.Alunos.save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!AlunoExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return StatusCode(HttpStatusCode.NoContent);
		}

		// POST: api/AlunosApi
		[HttpPost]
		[ResponseType(typeof(Aluno))]
		public IHttpActionResult Add(Aluno aluno)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			svc.Alunos.Add(aluno);
			svc.Alunos.save();

			return CreatedAtRoute("DefaultApi", new { id = aluno.Id }, aluno);
		}

		// DELETE: api/AlunosApi/5
		[ResponseType(typeof(Aluno))]
		public IHttpActionResult Delete(int id)
		{
			Aluno aluno = svc.Alunos.GetById(id);
			if (aluno == null)
			{
				return NotFound();
			}

			svc.Alunos.Delete(aluno);
			svc.Alunos.save();

			return Ok(aluno);
		}
	
		private bool AlunoExists(int id)
		{
			return svc.Alunos.All().Count(e => e.Id == id) > 0;
		}
	}
}