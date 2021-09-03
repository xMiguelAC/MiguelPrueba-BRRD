using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiguelPrueba.Models;

namespace MiguelPrueba.Database
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<Persona> personas { get; set; }
    }
}
