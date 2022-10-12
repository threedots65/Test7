using Data;
namespace User.Create
{
    public class Response : TokenedDataResponse<UserKey>
    {
        public Response(UserKey result)
            : base(result)
        {
        }
    }
}