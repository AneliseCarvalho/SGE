﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SGE.Models
{
        [Table("Professores")]
        public class Professores
        {
            [Column("Id")]
            [Display(Name = "Código do Professor")]
            public int Id { get; set; }

            [Column("Nome")]
            [Display(Name = "Nome")]
            public string Nome { get; set; } = string.Empty;

            [Column("Email")]
            [Display(Name = "E-mail")]
            public string Email { get; set; } = string.Empty;

            [Column("Telefone")]
            [Display(Name = "Telefone")]
            public string Telefone { get; set; } = string.Empty;

            [Column("Cpf")]
            [Display(Name = "Cpf")]
            public string Cpf { get; set; } = string.Empty;

            [Column("DataNascimento")]
            [Display(Name = "Data de Nascimento")]
            public string DataNascimento { get; set; } = string.Empty;

        }
    }
