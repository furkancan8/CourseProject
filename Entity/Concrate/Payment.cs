using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CvcCode{ get; set; }
    }
}
