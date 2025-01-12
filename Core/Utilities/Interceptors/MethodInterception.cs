using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            bool isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch(Exception ex){
                isSuccess = false;

                OnException(invocation);
            }
            finally{
                if(isSuccess)
                    OnSuccess(invocation);
            }
            OnAfter(invocation);    

        }
    }
}
