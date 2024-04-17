using Esercitazione17Aprile.Models;
using Esercitazione17Aprile.Service;
using Microsoft.AspNetCore.Mvc;

namespace Esercitazione17Aprile.Controllers
{
    public class ImpiegatoController : Controller
    {
        private readonly ImpiegatoService service;

        public ImpiegatoController(ImpiegatoService service)
        {
            this.service = service;
        }

        public IActionResult Inserimento()
        {
            ViewBag.ListaReparti = service.RecuperaReparti();
            return View();
        }

        public IActionResult Salvataggio(Impiegato i)
        {
            if (service.InserisciImpiegato(i))
                return Redirect("/Impiegato/Lista");
            else
                return Redirect("/Impiegato/Errore");
        }

        public IActionResult Lista() 
        {
            return View(service.RecuperaTutti());
        }
    }
}
