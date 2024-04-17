using Esercitazione17Aprile.Models;
using System.Runtime.CompilerServices;

namespace Esercitazione17Aprile.Repository
{
    public class RepartoRepository : IRepository<Reparto>
    {
        private readonly Esercitazione17AprileContext ctx;

        public RepartoRepository(Esercitazione17AprileContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Inserisci(Reparto t)
        {
            try
            {
                ctx.Repartos.Add(t);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Reparto> GetAll()
        {
            return ctx.Repartos.ToList();
        }
    }
}
