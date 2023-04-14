using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    //result=sonuç
    public interface IResult
    {
         bool Success { get; }//set özelligini aktif edilmez ise başka yerde success çagrılamaz yani Result içinden kullanılamaz.ama constructors da set edilebilir.
         string Massage { get;  }
    }
}
