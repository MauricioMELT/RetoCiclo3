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
                new Aeropuertos{id=2,nombre="jose cano",ciudad= "Medellin",pais= "Colombia",coord_x= "16.9788",coord_y= "56.65"},
                new Aeropuertos{id=3,nombre="eden",ciudad= "Armenia",pais= "Colombia",coord_x= "24.665",coord_y= "67.8867"}
 
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }

        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
           if(aeropuertos.Count > 0){
           newAeropuerto.id=aeropuertos.Max(r => r.id) +1; 
            }else{
               newAeropuerto.id = 1; 
            }
           aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }

        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
            }
        return aeropuerto;
        }

        public Aeropuertos Delete(int id)
        {
        var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == id);
        aeropuertos.Remove(aeropuerto);
        return aeropuerto;
        }


    }
}
