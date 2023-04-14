using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
   public interface ICacheManager
    {
        //key:her işlem için oluşturulan string metin.
        T Get<T>(string key);//generic veri tipi çünkü tipi herşey olabilir,
        object Get(string key);
        void Add(string key, object value, int duration);//value abject olduğu için herşey atanabilir. 
        bool IsAdd(string key);//Cache ekleme yapmak için
        void Remove(string key);//Cache silme yapmak için
        void RemoveByPattern(string pattern);//Cache silme yapmak için ama şartlı
    }
}
