using AspNetMvc5Demo0.DataAccess.Models;
using AspNetMvc5Demo0.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc5Demo0.DataAccess.Service
{
	//public class Service : IService
	//{
	//	private Repository<Student> _alunos;
		
	//	private bool _disposed;

	//	private DbEntities _ctx;
	//	public Service()
	//	{
	//		_ctx = new DbEntities();
	//	}

	//	public Repository<Student> Alunos
	//	{
	//		get
	//		{
	//			if (_alunos == null)
	//			{
	//				_alunos = new Repository<Student>(_ctx);
	//			}
	//			return _alunos;
	//		}

	//	}


	//	public void Dispose()
	//	{
	//		Dispose(true);
	//		GC.SuppressFinalize(this);
	//	}

	//	protected virtual void Dispose(bool disposing)
	//	{
	//		if (!this._disposed)
	//		{
	//			if (disposing)
	//			{
	//				_ctx.Dispose();
	//			}

	//			this._disposed = true;
	//		}
	//	}
	//}
}
