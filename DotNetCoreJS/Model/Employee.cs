using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreJS.Model
{
    [Table("EmployeeDetails")]
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Country { get; set; }
    }
}
