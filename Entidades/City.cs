//using System;
using System.Collections.Generic; //ESTE USAMOS PARA EL ICOLLECTION
using System.ComponentModel.DataAnnotations; //para usar el range

namespace ProyectoDePrueba.Entidades
{
    public class City
    {
        public int Id { get; set; }
        [MaxLength(8)] //esto afecata a la propiedad imagen

        public string Image { get; set; }

        public string Demonination { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }

        //TODO : RELACION CON ICONOS
        public ICollection<GeographicsIcon> Geographics { get; set; }

        //TODO : RELACION CON CONTINENTES
        public Continent Continent { get; set; } //RELACION UNO A MUCHOS


    }
}
