using System.ComponentModel.DataAnnotations;

namespace MVC_First.Models
{
    public class Employee
    {

        public int id { get; set; }
        public required string name { get; set; }
        public int? age {  get; set; }

        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
        public string city {  get; set; }
 

    }
}
