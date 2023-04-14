using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class UserContact:IEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
