using Esercitazione17Aprile.Models;
using Microsoft.EntityFrameworkCore;

namespace Esercitazione17Aprile.Repository
{
    public class ImpiegatoRepository : IRepository<Impiegato>
    {
        private readonly Esercitazione17AprileContext ctx;

        public ImpiegatoRepository (Esercitazione17AprileContext ctx)
        {
            this.ctx = ctx;
        }
        public List<Impiegato> GetAll()
        {
            return ctx.Impiegatos.Include(r=>r.RepartoRifNavigation).ToList();
        }

        public bool Inserisci(Impiegato t)
        {
            try
            {
                ctx.Impiegatos.Add(t);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
