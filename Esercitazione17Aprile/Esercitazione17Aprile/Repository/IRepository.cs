namespace Esercitazione17Aprile.Repository
{
    public interface IRepository<T>
    {
        public bool Inserisci(T t);
        public List<T> GetAll();
    }
}
