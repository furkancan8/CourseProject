using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CourseVideo:IEntity
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int CourseId { get; set; }

    }
}
