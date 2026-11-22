using MVCProject849.Context;

namespace MVCProject849.Services
{
    public class DeparmentService
    {
        // BL About Deparment

       CompanyContext CompanyContext = new CompanyContext();
        public List<Models.Department> GetAllDepartments()
        {
            return CompanyContext.Departments.ToList();
        }

        public Models.Department GetDepartmentById(int id)
        {
            return CompanyContext.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Add(Models.Department department)
        {
            CompanyContext.Departments.Add(department);
            CompanyContext.SaveChanges();
        }

        public void Update(Models.Department department)
        {
            var deparment = CompanyContext.Departments.FirstOrDefault(d => d.Id == department.Id);
            if (deparment != null)
            {
                deparment.Name = department.Name;
                deparment.MangerName = department.MangerName;
                deparment.Code = department.Code;
                CompanyContext.SaveChanges();
            }
        }

        public void Delete(int id )
        {
            var deparment = CompanyContext.Departments.FirstOrDefault(d => d.Id == id);
            if (deparment != null)
            {
                CompanyContext.Departments.Remove(deparment);
                CompanyContext.SaveChanges();
            }
        }

    }
}
