using System;
using System.ComponentModel.DataAnnotations;

namespace Teo_PC03.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="Por favor, ingrese un Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="Por favor, ingrese una Foto")]
        public string Url { get; set; }

        [Required(ErrorMessage="Por favor, ingrese una Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage="Por favor, ingrese un Precio")]
        public double Precio { get; set; }

        [Required(ErrorMessage="Por favor, ingrese un número Celular")]
        public int Celular { get; set; }

        [Required(ErrorMessage="Por favor, ingrese un Lugar")]
        public string Lugar { get; set; }

        [Required(ErrorMessage="Por favor, ingrese un Nombre de Usuario")]
        public string NomUsu { get; set; }

        public DateTime FecRes { get; set; }
    }
}