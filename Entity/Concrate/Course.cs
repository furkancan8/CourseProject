using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Completed { get; set; }
        public int TeacherId { get; set; }

    }
}
