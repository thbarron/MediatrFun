﻿using System;

namespace MediatrFun.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedMoment { get; set; }
        public DateTime UpdatedMoment { get; set; }
    }
}