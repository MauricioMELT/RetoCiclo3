using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
 
    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="dorado",ciudad= 'Bogotà',pais= 'Colombia',coord_x= 4,coord_y= 34},
                new Aeropuertos{id=2,nombre="jose cano",ciudad= 'medellin',pais= 'Colombia',coord_x= 16,coord_y= 56},
                new Aeropuertos{id=3,nombre="mediterraneo",ciudad= 'melgar',pais= 'Colombia',coord_x= 24,coord_y= 67}
 
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetBusWithId(int id){
            return buses.SingleOrDefault(b => b.id == id);
        }
    }
}
