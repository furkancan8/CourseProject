using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class SectionCourse:IEntity
    {
        public int SectionCourseId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }

    }
}
