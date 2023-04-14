using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{//hash oluşturup-dogrulamaya yarar
    public class HashingHelper
    {
        //create ile passwordhash oluşturulur,kullanıcı sisteme girmek istediğinde verdigi şifre ile tekrar hash oluşturulur ve veritabanındaki
        //hash ile karşılat
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //hmacsha512 hash oluşturma algoritması
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password,byte[] passwordHash,byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//dogrulama yapmak için salt veriyoruz
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i <computedHash.Length; i++)
                {

                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;

                    }
                }
                return true;
            }
        }
    }
}
