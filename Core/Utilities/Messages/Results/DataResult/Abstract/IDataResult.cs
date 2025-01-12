
using Core.Utilities.Messages.Results.Result.Abstract;

namespace Core.Utilities.Messages.Results.DataResult.Abstract
{
    public interface IDataResult<T> : IResult
     {
        T Result { get;}
    }
}
