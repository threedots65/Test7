using Data;
namespace User.Edit
{
    public class Request : ICommand<Response>
    {
        public UserKey UserKey { get; set; }
        
        public string Name { get; set; }
    }
}