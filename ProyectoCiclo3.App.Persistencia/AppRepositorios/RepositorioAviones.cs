using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Aviones> GetAll()
        {
            return _appContext.Aviones;
        }
 
        public Aviones GetAvionWithId(int id){
            return _appContext.Aviones.Find(id);
        }
 
        public Aviones Update(Aviones newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.asientos = newAvion.asientos;
                avion.banos = newAvion.banos;
                avion.peso = newAvion.peso;

                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return avion;
        }
 
        public Aviones Create(Aviones newAvion)
        {
            var addAvion = _appContext.Aviones.Add(newAvion);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addAvion.Entity;
        }
 
        public void Delete(int id)
        {
            try {
            var avion = _appContext.Aviones.Find(id);
            if (avion != null){
                _appContext.Aviones.Remove(avion);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            }catch (Exception e){
                
            }
        }
    }
}
