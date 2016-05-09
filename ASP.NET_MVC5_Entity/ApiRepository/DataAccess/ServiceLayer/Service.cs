using ApiRepository.DataAccess.Repository;
using ApiRepository.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRepository.DataAccess.ServiceLayer
{
	public class Service : IService
	{
		private Repository<Aluno> _alunos;
		private Repository<Curso> _cursos;
		private Repository<Professor> _professors;
		private bool _disposed;

		private DbEntities _ctx;
		public Service()
		{
			_ctx = new DbEntities();
		}

		public Repository<Aluno> Alunos
		{
			get
			{
				if (_alunos == null)
				{
					_alunos = new Repository<Aluno>(_ctx);
				}
				return _alunos;
			}

		}

		public Repository<Curso> Cursos
		{
			get
			{
				if (_cursos == null)
				{
					_cursos = new Repository<Curso>(_ctx);
				}
				return _cursos;
			}

		}

		public Repository<Professor> Professors
		{
			get
			{
				if (_professors == null)
				{
					_professors = new Repository<Professor>(_ctx);
				}
				return _professors;
			}

		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing)
				{
					_ctx.Dispose();
				}

				this._disposed = true;
			}
		}
	}
}
