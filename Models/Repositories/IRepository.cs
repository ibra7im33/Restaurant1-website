namespace Restorent.Models.Repositories
{
    public interface IRepository<T>
    {
        void Active(int id, T entity);
        void Add(T entity);
        void Delete (int id , T entity );
        T Find(int T);
        void Update (int id , T entity);
        IList<T> View();
        IList<T> ViewFormClient();

    }
}
