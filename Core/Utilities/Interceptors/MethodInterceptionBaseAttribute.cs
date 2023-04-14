using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //class,method eklenebilir,birden fazla eklenebilir ve kullanılabilir,2 tane aynı attribute çagırlabilir farklı parametrelerle.
    //method ve class çalışmadan önce,sonra veya hata verince.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }

    }
}
