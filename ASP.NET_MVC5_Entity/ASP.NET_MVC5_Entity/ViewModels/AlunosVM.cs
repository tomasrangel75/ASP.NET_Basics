using ASP.NET_MVC5_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_MVC5_Entity.ViewModels
{
	public class AlunosVM
	{

		public Aluno aluno { get; set; }

		public IEnumerable<Aluno> alunos { get; set; }
	}
}
