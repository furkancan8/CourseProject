using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            //ReflectedType.FullName=Business.Concrate+IProductService.metodun ismi(1 yani parametre)//belekteki metotlar karışmasın diye
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");//reflectedtype.metodun ismi
            var arguments = invocation.Arguments.ToList();//metodun parametrelerini list yapar
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";//parametreleri ekler// ?? varsa sagdakini yoksa soldakini ekle
            if (_cacheManager.IsAdd(key))//cache anaktarı bellekte var mı kontrol eder
            {
                invocation.ReturnValue = _cacheManager.Get(key);//metodu çalıştırma,onun yerine cache deki metodu çalıştır
                return;
            }
            invocation.Proceed();//bellekte yoksa metodu çalıştır
            _cacheManager.Add(key, invocation.ReturnValue, _duration);//çalışan metodu cache bellek'e ekler
        }
    }
}