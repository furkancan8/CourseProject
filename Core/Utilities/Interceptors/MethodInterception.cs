using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {//IInvocation method veya class ı temsil eder.Business taki metotlar
        //methodlar çalışmadan önce ıntercept in içindeki kodlardan geçicek ve sonra çalışıcak
        //virtual ezilmeyi bekleyen methodlardır.attributları nerde çalışıcak ise ona göre aşagıdaki metotlar ovverride edilir.
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
