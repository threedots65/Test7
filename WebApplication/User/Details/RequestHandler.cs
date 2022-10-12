using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data;
using MediatR;

namespace User.Details
{
    public class RequestHandler : IQueryHandler<Request, Response>
    {
        private readonly IDataContext dataContext;
        private readonly IMediator mediator;

        public RequestHandler(IDataContext dataContext, IMediator mediator)
        {
            this.dataContext = dataContext;
            this.mediator = mediator;
        }

        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
           
            Data.User user = GetUserDetails(request);

            return new Response(user);
        }

        private Data.User GetUserDetails(Request request)
        {
            return this.dataContext.UserContext.Get().FirstOrDefault(x => x.Id == request.UserKey.UserId);
        }

      
    }
}