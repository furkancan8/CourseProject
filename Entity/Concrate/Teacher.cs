using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class Teacher : IEntity
    {
        public int TeacherId { get; set; }
        public string Description { get; set; }
        public string YoutubeUrl { get; set; }
        public string WebUrl { get; set; }
    }
}
