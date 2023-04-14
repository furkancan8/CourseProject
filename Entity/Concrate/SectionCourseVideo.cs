using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class SectionCourseVideo:IEntity
    {
        public int Id { get; set; }
        public int SectionCourseId { get; set; }
        public int VideoId { get; set; }

    }
}
