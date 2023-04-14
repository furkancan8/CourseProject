using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string massage):base(data,true,massage)
        {

        }
        public SuccessDataResult(T data):base(data,true)
        {

        }
        public SuccessDataResult(string massage):base(default,true,massage)//default Tdata ya karşılık gelir data döndürmek istemez defult döndürür
        {

        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
