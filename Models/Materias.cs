using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Código da Matéria")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("ProfessoresId")]
        [Display(Name = "Código do Professor")]
        public int ProfessoresId { get; set; }
    }
}
