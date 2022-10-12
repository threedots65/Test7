using Data;

namespace User.Details
{
    public class Response : TokenedDataResponse<Data.User>
    {
        public Response(Data.User user)
            : base(user)
        {
        }
    }
}