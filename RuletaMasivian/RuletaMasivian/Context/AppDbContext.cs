using Microsoft.EntityFrameworkCore;
using RuletaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuletaMasivian.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {}
        public DbSet<Apuestas> apuestas { get; set; }
        public DbSet<Premios> premios { get; set; }
        public DbSet<Ruletas> ruletas { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
    }
}
