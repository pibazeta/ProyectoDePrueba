using System;

namespace ProyectoDePrueba.Entidades
{
    public class GeographicsIcon
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Demonination { get; set; }

        public DateTime CreationDate { get; set; }

        public int  Height { get; set; }

        public string History { get; set; }

        public City City { get; set; }

        //TODO: RELACION CON CIUDAD
    }
}
