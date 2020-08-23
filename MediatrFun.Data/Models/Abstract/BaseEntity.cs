using System;

namespace MediatrFun.Data.Models.Abstract
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime CreatedMoment { get; set; }
        public DateTime UpdatedMoment { get; set; }
    }
}