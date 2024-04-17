using Esercitazione17Aprile.Models;
using Esercitazione17Aprile.Repository;

namespace Esercitazione17Aprile.Services
{
    public class RepartoService
    {
        private readonly RepartoRepository repo;

        public RepartoService(RepartoRepository repo)
        {
            this.repo = repo;
        }

        public bool InserisciReparto(Reparto r)
        {
            return repo.Inserisci(r);
        }

        public List<Reparto> RecuperaTutti()
        {
            return repo.GetAll();
        }
    }
}
