using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NotasEstudiantesPolitecnico.Models
{
    public class Datos
    {
        public int Id { get; set; }
        public String Estudiante { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal NotaFinal { get; set; }
    }
}
