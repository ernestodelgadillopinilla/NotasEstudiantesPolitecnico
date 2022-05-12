using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotasEstudiantesPolitecnico.Models
{
    public class NotasEstudiantesPolitecnicoContext : DbContext
    {
        public NotasEstudiantesPolitecnicoContext (DbContextOptions<NotasEstudiantesPolitecnicoContext> options)
            : base(options)
        {
        }

        public DbSet<NotasEstudiantesPolitecnico.Models.Datos> Datos { get; set; }
    }
}
