using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Medicinas
    {
        [Key]
        public int MedicinaId { get; set; }
        public string Nombre { get; set; }
        public int CantidadExistencia { get; set; }
        public float Precio { get; set; }
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public int LaboratorioId { get; set; }
    }
}