using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrate
{
    public class SoldCourse:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }=DateTime.Now;
        public int SalePrice { get; set; }
        public int KDV { get; set; }
        public int CompanyShare { get; set; }

    }
}
