//using System;
using System.Collections.Generic; //ESTE USAMOS PARA EL ICOLLECTION

namespace ProyectoDePrueba.Entidades
{
    public class Continent
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Demonination { get; set; }

        //TODO : RELACION CON CIUDADES

        public ICollection<City> Cities { get; set; } //Relacion con ciudades. //RELACION UNO A MUCHOS (relacion de continentes con ciudades)















    }
}
