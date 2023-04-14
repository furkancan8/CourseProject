using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class VideoDetail:IEntity
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public decimal Time { get; set; }
        public string VideoUrl { get; set; }

    }
}
