using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Data
{
    public abstract class CommandHandler<TRequest> : IRequestHandler<TRequest, Unit>
        where TRequest : ICommand
    {
        public async Task<Unit> Handle(TRequest request, CancellationToken cancellationToken)
        {
            await HandleRequestAsync(request, cancellationToken);

            return Unit.Value;
        }

        protected abstract Task HandleRequestAsync(TRequest request, CancellationToken cancellationToken);
    }

    public abstract class CommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : ICommand<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var result = await HandleRequestAsync(request, cancellationToken);

            return result;
        }

        protected abstract Task<TResponse> HandleRequestAsync(TRequest request, CancellationToken cancellationToken);
    }
}