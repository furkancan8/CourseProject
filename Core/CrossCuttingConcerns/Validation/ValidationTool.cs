using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {//IValidator business taki validatorlardır onların base i de IValidatordır.entity ise dogrulanacak olan class dır yani product
        public static void Validate(IValidator validator,object entity)//validate i çalıştıran fonksiyon eger şartlara uymaz ise hata verir
        {
            var context = new ValidationContext<object>(entity);    
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
