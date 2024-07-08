using CoreFirstCoreF.K.DropDown.Contract;
using CoreFirstCoreF.K.DropDown.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreFirstCoreF.K.DropDown.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeDbContext _dbEmp;
        public EmployeeService(EmployeeDbContext dbEmp)
        {
            _dbEmp = dbEmp;
        }
        public bool addEmployee(Employee empObj)
        {
            _dbEmp.Add(empObj);
            int n=_dbEmp.SaveChanges();
            if(n!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<City> GetCities()
        {
            var cities = _dbEmp.Cities.ToList();
            return cities;
        }

        public List<Department> GetDepartments()
        { 
            var departments = _dbEmp.Departments.ToList();
            return departments;
        }

        public List<EmployeeDetailViewModel> GetEmployees()
        {
            var query = from employee in _dbEmp.Employees
                        join city in _dbEmp.Cities on employee.City equals city.city_id
                        join department in _dbEmp.Departments on employee.Did equals department.Did
                        select new EmployeeDetailViewModel
                        {
                            Eid=employee.Eid,
                            Name = employee.Ename,
                            Age = employee.age,
                            MobileNo = employee.Mobileno,
                            City = city.city_name,
                            Salary= employee.Salary,
                            Department=department.Dname
                        };
           return query.ToList();
        }
        public List<EmployeeDetailViewModel> DepartmentWiseEmployeeDetails(int DepartmentId)
        {
            var query = from employee in _dbEmp.Employees
                        join city in _dbEmp.Cities on employee.City equals city.city_id
                        join department in _dbEmp.Departments  on employee.Did equals department.Did where department.Did== DepartmentId
                        select new EmployeeDetailViewModel
                        {
                            Eid = employee.Eid,
                            Name = employee.Ename,
                            Age = employee.age,
                            MobileNo = employee.Mobileno,
                            City=city.city_name,
                            Salary = employee.Salary,
                            Department = department.Dname.ToString()
                        };
            return query.ToList();
        }

    }
}
