using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
   public interface ITokenHelper
    {//kulanıcının verdigi bilgileri api bilgiler dogru ise veritabanına gidip claimleri buluşturup bir token
     //oluşturcak ve kullanıcıya vericek
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);



    }
}
