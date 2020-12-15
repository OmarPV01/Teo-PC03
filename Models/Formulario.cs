using System;
using System.ComponentModel.DataAnnotations;

namespace Teo_PC03.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; }

        public string Url { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public int Celular { get; set; }
        public string Lugar { get; set; }

        public string NomUsu { get; set; }

        public DateTime? FecNac { get; set; }
    }
}