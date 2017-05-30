using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class CategoriaMedicinas
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
    }
}