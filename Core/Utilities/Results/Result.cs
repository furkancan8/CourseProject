using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this=bu;yani  method çalıştıgı zaman aşagıdaki success te çalışıcak ama aşagıdak içalıştıgın da bu çalışmıyacak
        public Result(bool success, string massage) : this(success)//Result'ın tek parametreli olan const ına bunu da yolla,kod tekrar etmedi
        {
            Massage = massage;
        }
        public Result(bool success)
        {    
            Success = success;
        }   
        public bool Success { get; }

        public string Massage { get; }
    }
}
