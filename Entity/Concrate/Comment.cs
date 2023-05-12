using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
