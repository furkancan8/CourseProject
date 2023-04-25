using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class UserVerify:IEntity
    {
        public int Id { get; set; }
        public string UserMail { get; set; }
        public string RandomCode{ get; set; }
    }
}
