using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autos.Web.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [Display(Name ="Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Año")]
        public int Año { get; set; }
        [Display(Name = "Tipo de combustible")]
        public string Combustible { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Display(Name = "Precio")]
        public double Precio { get; set; }
        [Display(Name = "Fecha de publicación")]
        public DateTime Fecha { get; set; }
    }
}