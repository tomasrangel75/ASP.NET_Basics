using ApiRepository.DataAccess.Repository;
using ApiRepository.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRepository.DataAccess.ServiceLayer
{
	public interface IService : IDisposable
	{
		Repository<Aluno> Alunos { get; }
		Repository<Curso> Cursos { get; }
		Repository<Professor> Professors { get; }
	}
}
