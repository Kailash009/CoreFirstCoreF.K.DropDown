using CoreFirstCoreF.K.DropDown.Models;
using System.Security.Cryptography;

namespace CoreFirstCoreF.K.DropDown.Contract
{
    public interface IEmployee
    {
        List<EmployeeDetailViewModel> GetEmployees();
        bool addEmployee(Employee empObj);
        List<City> GetCities();
        List<Department> GetDepartments();
        List<EmployeeDetailViewModel> DepartmentWiseEmployeeDetails(int DepartmentId);

    }
}
