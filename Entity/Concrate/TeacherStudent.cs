using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class TeacherStudent:IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
    }
}
