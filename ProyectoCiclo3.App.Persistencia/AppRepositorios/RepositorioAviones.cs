using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Airbus",modelo= "Airbus A220",asientos= 140,banos= 3,peso= 50},
                new Aviones{id=2,marca="Airbus",modelo= "Airbus A321",asientos= 240,banos= 4,peso= 49},
                new Aviones{id=3,marca="Embraer",modelo= "Embraer 190",asientos= 100,banos= 2,peso= 45}
 
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetAvionWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
    }
}
