using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CourseDetails:IEntity
    {
        public int CourseDetailsId { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public int CourseId { get; set; }

    }
}
