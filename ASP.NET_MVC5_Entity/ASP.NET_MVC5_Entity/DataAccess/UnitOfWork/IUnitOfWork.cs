﻿using ASP.NET_MVC5_Entity.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASP.NET_MVC5_Entity.DataAccess.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
		void Save();
	}
}
