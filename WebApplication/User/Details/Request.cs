using Data;

namespace User.Details
{
    public class Request : IQuery<Response>
    {
        public Request(UserKey userKey)
        {
            UserKey = userKey;
        }

        public UserKey UserKey { get; }
    }
}