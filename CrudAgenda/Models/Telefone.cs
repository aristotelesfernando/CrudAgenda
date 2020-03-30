using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudAgenda.Models
{
    [Table("Telefones")]
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}