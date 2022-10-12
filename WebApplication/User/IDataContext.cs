namespace Data
{
    public interface IDataContext
    {
        IEntityContext<User> UserContext { get; }
       
    }
}