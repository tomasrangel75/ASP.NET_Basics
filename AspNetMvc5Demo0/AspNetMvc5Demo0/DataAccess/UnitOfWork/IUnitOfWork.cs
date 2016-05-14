using AspNetMvc5Demo0.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc5Demo0.DataAccess.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
		void Save();
	}
}
