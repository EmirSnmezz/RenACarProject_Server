namespace Core.Utilities.Messages.Results.DataResult.Concrete
{
    public class SuccessDataResult <T>: DataResult<T>
    {
        public SuccessDataResult(T result): base(result, true) {}

        public SuccessDataResult(T result,string message): base(result,true,message) {}

        public SuccessDataResult(string message):base(default, true, message) {}

        public SuccessDataResult(): base(default, true) {}
    }
}
