using Esercitazione17Aprile.Models;
using Esercitazione17Aprile.Services;
using Microsoft.AspNetCore.Mvc;

namespace Esercitazione17Aprile.Controllers
{
    public class RepartoController : Controller
    {
        private readonly RepartoService service;

        public RepartoController (RepartoService service)
        {
            this.service = service;
        }


        public IActionResult Inserimento()
        {
            
            return View();
        }

        public IActionResult Lista()
        {
            return View(service.RecuperaTutti());
        }

        public IActionResult Salvataggio( Reparto r )
        {
            if(service.InserisciReparto(r))
                return Redirect("/Reparto/Lista");
            else
                return Redirect("/Reparto/Errore");
        }
    }
}
