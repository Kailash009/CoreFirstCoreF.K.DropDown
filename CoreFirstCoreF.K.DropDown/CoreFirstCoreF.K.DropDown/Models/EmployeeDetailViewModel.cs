using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreFirstCoreF.K.DropDown.Models
{
    public class EmployeeDetailViewModel
    {
        [Key]
        public int Eid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public int DepartmentId { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
