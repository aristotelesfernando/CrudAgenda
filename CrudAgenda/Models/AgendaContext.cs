using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAgenda.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        public AgendaContext() : base("Agenda")
        {
            Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);
        }

    }
}