namespace StoreDL
{
    public interface IRepository<T>
    {
        void Add(T c_resource);

        List<T> GetAll();

        void Update(T c_resource);
    }
}