using Esercitazione17Aprile.Models;
using Esercitazione17Aprile.Repository;
using Esercitazione17Aprile.Services;

namespace Esercitazione17Aprile.Service
{
    public class ImpiegatoService
    {
        private readonly RepartoService reparto;
        private readonly ImpiegatoRepository repo;

        public ImpiegatoService(ImpiegatoRepository repo, RepartoService service)
        {
            this.repo = repo;
            this.reparto = service;
        }

        public bool InserisciImpiegato(Impiegato i)
        {

            return repo.Inserisci(i);
        }

        public List<Impiegato> RecuperaTutti()
        {
            return repo.GetAll();
        }

        public List<Reparto> RecuperaReparti()
        {
            return reparto.RecuperaTutti();
        }
    }
}
