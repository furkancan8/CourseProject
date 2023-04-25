using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class TeacherCourse:IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }

    }
}
