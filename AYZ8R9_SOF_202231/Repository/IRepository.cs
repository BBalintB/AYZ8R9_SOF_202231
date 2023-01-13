namespace AYZ8R9_SOF_202231.Repository
{
    public interface IRepository<T> where T : class
    {
        void Create(T NewEntity);
        void Change(T NewEntity);
        void Delete(string id);
        IQueryable<T> GetAll();
        T GetOne(string id);
    }
}