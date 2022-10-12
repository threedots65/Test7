using Data;
namespace User.Edit
{
    public class Response : TokenedDataResponse<SucceededResult>
    {
        public Response(bool isSucceeded)
            : base(new SucceededResult(isSucceeded))
        {
        }
    }
}