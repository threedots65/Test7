using System.Threading;
using System.Threading.Tasks;
using Data;
using MediatR;

namespace User.Edit
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

            bool isSucceeded = EditUser(request);

            return new Response(isSucceeded);
        }

        private bool EditUser(Request request)
        {
            var result = this.dataContext.UserContext.Edit(
                            request.UserKey.UserId,
                            new Data.User
                            {
                                Name = request.Name
                            });

            return result;
        }

      
    }
}