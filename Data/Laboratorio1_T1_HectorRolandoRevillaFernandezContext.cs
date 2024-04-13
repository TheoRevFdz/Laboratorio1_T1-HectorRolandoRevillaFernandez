using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laboratorio1_T1_HectorRolandoRevillaFernandez.Models;

namespace Laboratorio1_T1_HectorRolandoRevillaFernandez.Data
{
    public class Laboratorio1_T1_HectorRolandoRevillaFernandezContext : DbContext
    {
        public Laboratorio1_T1_HectorRolandoRevillaFernandezContext (DbContextOptions<Laboratorio1_T1_HectorRolandoRevillaFernandezContext> options)
            : base(options)
        {
        }

        public DbSet<Laboratorio1_T1_HectorRolandoRevillaFernandez.Models.Ventas> Ventas { get; set; } = default!;
    }
}
