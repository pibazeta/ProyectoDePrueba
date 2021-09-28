
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //se agrega para la DbContext
using ProyectoDePrueba.Entidades; //se agrega para los Dbset<> que es la carpeta que tiene las entidades

namespace ProyectoDePrueba.Context
{
    public class IconsContext :DbContext  

    {
        public const string Schema = "icons";

        //constructor
        public IconsContext(DbContextOptions options) : base(options)
        {

        }

        //Reescribiendo un metodo,
        //se usa para crear nuestro modelo de base de datos
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }


        public DbSet<GeographicsIcon> GeographicsIcons { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<City> Cities { get; set; }








    }
}
