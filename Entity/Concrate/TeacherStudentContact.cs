using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class TeacherStudentContact:IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
