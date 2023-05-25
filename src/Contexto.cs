using Barbearia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Barbearia.Data
{
    public class Contexto : IdentityDbContext
    {

        public Contexto(){}
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        public DbSet<Agendamentos> Agendamentos { get; set; }
    }
}