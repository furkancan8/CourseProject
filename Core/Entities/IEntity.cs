using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    //Core katmanı EVRENSEL kuralların bulundugu KATMANDIR ve hiç bir projeye baglı degildir yani entityrepository ve entity evrensel class lardır.
    //Core katmanı projeler için belli kuralların yazıldıgı yerdir ve bütün projelerde kullanılabilir.
    //DataAccess ve Entites şuan Core ref aldı ve core bagımlı durumdalar.
    public interface IEntity
    {

    }
}
