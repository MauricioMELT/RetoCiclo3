using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    [Authorize]
    public class DetailsAeropuertosModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
              public Aeropuertos Aeropuertos {get;set;}
 
        public DetailsAeropuertosModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }
 
        public IActionResult OnGet(int aeropuertoId)
        {
                Aeropuertos=repositorioAeropuertos.GetAeropuertoWithId(aeropuertoId);
                return Page();
 
        }
    }
}
