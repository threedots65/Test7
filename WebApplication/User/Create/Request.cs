using Data;
namespace User.Create
{
    public class Request : ICommand<Response>
    {
        public string Name { get; set; }
    }
}