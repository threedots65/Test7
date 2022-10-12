using MediatR;

namespace Data
{
    public interface ICommand : IRequest<Unit>
    {
    }

    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}