namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Object);
        Task Update (T Object);
        Task Delete(T Object);
        Task<T> GetById(int Id);
        Task<IEnumerable<T>> GetList();
    }
}
