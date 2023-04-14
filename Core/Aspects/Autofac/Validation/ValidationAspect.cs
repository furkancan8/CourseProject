using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)//VALİDATOR TYPE istiyor product-category
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu dogrulama sınıfı degildir");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)//MethodInterception içindeki onbefore ezildi,reflectiın methodu
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//reflection kodu productvalidator ü new ledi.ve IValidator tipinde kullanılabilir hale getirdi
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//productValidator ün base ine gidip 0 inci tip i aldı yani product ı,
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//IInvocation(method) parametrelerini alır-foreach ile gezip validate eder.
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
