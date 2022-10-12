using MediatR;

namespace Data
{
    public interface IQuery
    {
    }

    public interface IQuery<out TResult> : IRequest<TResult>, IQuery
    {
    }
}