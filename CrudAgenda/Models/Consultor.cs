using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudAgenda.Models
{
    [Table("Consultores")]
    public class Consultor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Nome do Consultor")]
        public string Nome { get; set; }
    }
}