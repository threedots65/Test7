using System.Threading;
using System.Threading.Tasks;
using Data;
using MediatR;
using User.Create;

namespace User.Create
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
            var user = this.dataContext
                .UserContext
                .Create(
                    new Data.User
                    {
                        Name = request.Name
                    });


            return new Response(new UserKey(user.Id));
        }
    }
}