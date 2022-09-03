using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListAeropuertosModel : PageModel
    {
       
        private readonly RepositorioAeropuertos RepositorioAeropuertos;
        public IEnumerable<Aeropuertos> Aeropuertos {get;set;}
 
    public ListAeropuertosModel(RepositorioAeropuertos RepositorioAeropuertos)
    {
        this.RepositorioAeropuertos=RepositorioAeropuertos;
     }
 
    public void OnGet()
    {
        Aeropuertos=RepositorioAeropuertos.GetAll();
    }
    }
}
