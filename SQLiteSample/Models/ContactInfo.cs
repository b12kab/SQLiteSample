using System;
using SQLite;

namespace SQLiteSample.Models
{
    [Table("ContactInfo")]
    public class ContactInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
