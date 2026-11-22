using MVCProject849.Context;

namespace MVCProject849.Services
{
    public class EmployeeService
    {
        // BL About Deparment

        CompanyContext CompanyContext = new CompanyContext();
        public List<Models.Employee> GetAllEmployees()
        {
            return CompanyContext.Employees.ToList();
        }

        public Models.Employee GetEmployeeById(int id)
        {
            return CompanyContext.Employees.FirstOrDefault(d => d.Id == id);
        }

        public void Add(Models.Employee employee)
        {
            CompanyContext.Employees.Add(employee);
            CompanyContext.SaveChanges();
        }

        public void Update(Models.Employee employee)
        {
            var emp = CompanyContext.Employees.FirstOrDefault(d => d.Id == employee.Id);
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Image = employee.Image;
                emp.Address = employee.Address;
                emp.Phone = employee.Phone;
                emp.DepartmentId = employee.DepartmentId;
                CompanyContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var emp = CompanyContext.Employees.FirstOrDefault(d => d.Id == id);
            if (emp != null)
            {
                CompanyContext.Employees.Remove(emp);
                CompanyContext.SaveChanges();
            }
        }

    }
}
