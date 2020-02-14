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
        public static void Add(EmployeeEntity employee)
        {
            employeeList.Add(employee);
        }
        public static void Delete(int employeeId)
        {
            EmployeeEntity employee = GetEmployeeById(employeeId);
            if (employee != null)
                employeeList.Remove(employee);
        }
        public static void Update(EmployeeEntity employee)
        {
            EmployeeEntity employeeEntity = employeeList.Find(id => id.EmployeeId == employee.EmployeeId);
            employeeEntity.EmployeeName = employee.EmployeeName;
            employeeEntity.Salary = employee.Salary;
            employeeEntity.City = employee.City;
        }
        public static EmployeeEntity GetEmployeeById(int employeeId)
        {
            return employeeList.Find(id => id.EmployeeId == employeeId);
        }
    }
}
