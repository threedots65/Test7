namespace Data
{
    public interface IEntityContext<T>
        where T : IEntity
    {
        T Create(T entity);
        bool Edit(int id, T entity);
     
        bool Delete(int id);
    }
}
