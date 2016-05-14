using AspNetMvc5Demo0.DataAccess.Models;
using AspNetMvc5Demo0.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc5Demo0.DataAccess.Service
{
	public interface IService : IDisposable
	{
		Repository<Student> Students { get; }

	}
}
