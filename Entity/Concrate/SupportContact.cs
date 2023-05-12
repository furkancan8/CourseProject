using Core.Entities;
using System;

namespace Entity.Concrate
{
    public class SupportContact:IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public string HelperId { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsRead { get; set; }
        public string HaveId { get; set; }

    }
}
