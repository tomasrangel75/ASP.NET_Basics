using APIProvider.DAL.Repository;
using APIProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProvider.ServiceLayer
{
	public interface IService : IDisposable
	{
		Repository<Aluno> Alunos { get; }
		Repository<Curso> Cursos { get; }
		Repository<Professor> Professors { get; }
	}
}
