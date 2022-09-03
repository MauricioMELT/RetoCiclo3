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
                new Aeropuertos{id=1,nombre="dorado",ciudad= "Bogota",pais= "Colombia",coord_x= "4.8888",coord_y= "34.343"},
                new Aeropuertos{id=2,nombre="jose cano",ciudad= "medellin",pais= "Colombia",coord_x= "16.9788",coord_y= "56.65"},
                new Aeropuertos{id=3,nombre="mediterraneo",ciudad= "melgar",pais= "Colombia",coord_x= "24.665",coord_y= "67.8867"}
 
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }
    }
}
