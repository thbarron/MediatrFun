using System;

namespace MediatrFun.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedMoment { get; set; }
        public DateTime UpdatedMoment { get; set; }
    }
}