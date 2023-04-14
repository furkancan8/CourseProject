using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string massage):base(success,massage)//base burda Result ı kastediyor,base deki suc,mas buraya alıyoruz
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
