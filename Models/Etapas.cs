using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Código da Etapa")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano da Etapa")]
        public int Ano { get; set; } 
    }
}
