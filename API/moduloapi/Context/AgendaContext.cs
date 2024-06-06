using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moduloapi.Entities;

// criando contexto
namespace moduloapi.Context
{
    public class AgendaContext : DbContext // db vem do pacote entity
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}