using MediatrFun.Data.Models.Abstract;

namespace MediatrFun.Data.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}