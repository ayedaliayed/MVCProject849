namespace MVCProject849.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MangerName { get; set; }
        public string Code { get; set; }
       List<Employee> Employees { get; set; }
    }
}
