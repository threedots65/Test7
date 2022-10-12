using Data;
namespace User.Delete
{
    public class Response : TokenedDataResponse<SucceededResult>
    {
        public Response(bool isSucceeded)
            : base(new SucceededResult(isSucceeded))
        {
        }
    }
}