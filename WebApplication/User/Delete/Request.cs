using Data;
namespace User.Delete
{
    public class Request : ICommand<Response>
    {
        public Request(UserKey userKey)
        {
            UserKey = userKey;
        }

        public UserKey UserKey { get; }
    }
}