using System.Threading;
using System.Threading.Tasks;
using Data;
using MediatR;

namespace User.Delete
{
    public class RequestHandler : CommandHandler<Request, Response>
    {
        private readonly IDataContext dataContext;
        private readonly IMediator mediator;

        public RequestHandler(IDataContext dataContext, IMediator mediator)
        {
            this.dataContext = dataContext;
            this.mediator = mediator;
        }

        protected override async Task<Response> HandleRequestAsync(Request request, CancellationToken cancellationToken)
        {
           

            bool isSucceeded = DeleteUser(request);

            return new Response(isSucceeded);
        }

        private bool DeleteUser(Request request)
        {
            return this.dataContext.UserContext.Delete(request.UserKey.UserId);
        }

       
    }
}