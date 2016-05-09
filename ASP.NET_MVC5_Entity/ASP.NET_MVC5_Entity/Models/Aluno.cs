//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET_MVC5_Entity.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
    
    public partial class Aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aluno()
        {
            this.CursosMatriculados = new HashSet<CursosMatriculado>();
        }

				public int Id { get; set; }

				[Required(ErrorMessage = "Campo Obrigatório")]
				[StringLength(50, MinimumLength = 3)]
				public string Nome { get; set; }

				[DisplayName("Data de Nascimento")]
				[Required(ErrorMessage = "Campo Obrigatório")]
				[DataType(DataType.Date)]
				[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
				public System.DateTime DtNascimento { get; set; }

				public int Idade
				{
					get
					{

						DateTime dtNow = DateTime.Today;
						int curAge = dtNow.Year - DtNascimento.Year;
						if (DtNascimento > dtNow.AddYears(-curAge))
						{
							curAge--;
						};
						return curAge;

					}

				}
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursosMatriculado> CursosMatriculados { get; set; }
    }
}
