using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoFinal.DAL
{
    public class FarmaciaDb : DbContext
    {
        public FarmaciaDb() : base ("ConStr")
        {

        }

        public DbSet<Models.Usuarios> Usuario { get; set; }
        public DbSet<Models.Clientes> Cliente { get; set; }
        public DbSet<Models.Medicinas> Medicina { get; set; }
        public DbSet<Models.Laboratorios> Laboratorio { get; set; }
        public DbSet<Models.CategoriaMedicinas> Categoria { get; set; }

    }
}