using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public  class CourseUser:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

    }
}
