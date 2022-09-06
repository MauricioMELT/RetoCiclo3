using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Medellin",destino= "Bogota",tiempo_estimado= 1},
                new Rutas{id=2,origen="Bogota",destino= "Guajira",tiempo_estimado= 2 },
                new Rutas{id=3,origen="Medellin",destino= "Amazonas",tiempo_estimado=4 }
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
    }
}

