using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params sayesinde istenildigi kadar IResult verilebilir
        {
            foreach (var logic in logics)//bütün kuralları gez
            {
                if (!logic.Success)//kurala uymayanları bul
                {
                    return logic; //kurala uymayanları döndür.
                }
            }
            return null;
        }
    }
}
