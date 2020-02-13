using Employee.Entity;
using System.Collections.Generic;
namespace Employee.DAL
{
    public class EmployeeRepository
    {
        public static List<EmployeeEntity> employeeList = new List<EmployeeEntity>();
        static EmployeeRepository()
        {
            employeeList.Add(new EmployeeEntity { EmployeeId = 101, EmployeeName = "Gomathi", Salary = 30000, City = "Dharapuram" });
            employeeList.Add(new EmployeeEntity { EmployeeId = 102, EmployeeName = "Abinaya", Salary = 35000, City = "Erode" });
            employeeList.Add(new EmployeeEntity { EmployeeId = 103, EmployeeName = "Sridhar", Salary = 34000, City = "Salem" });
            employeeList.Add(new EmployeeEntity { EmployeeId = 104, EmployeeName = "Ganesh", Salary = 30000, City = "Erode" });
        }
        public static IEnumerable<EmployeeEntity> GetDetails()
        {
            return employeeList;
        }
    }
}
