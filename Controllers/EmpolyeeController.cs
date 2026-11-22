using Microsoft.AspNetCore.Mvc;
using MVCProject849.Model_Views;
using MVCProject849.Models;
using MVCProject849.Services;

namespace MVCProject849.Controllers
{
    public class EmpolyeeController : Controller
    {
        EmployeeService EmployeeService = new EmployeeService();
        DeparmentService DeparmentService = new DeparmentService();
        public IActionResult Index()
        {
            var emp = EmployeeService.GetAllEmployees();
            return View(emp);

        }

        public IActionResult Details(int id)
        {
            var emp = EmployeeService.GetEmployeeById(id);
            var dept = DeparmentService.GetDepartmentById(emp.DepartmentId);

            EmpDetials empDetials = new EmpDetials();


            int salary = 50000;
            string nekname = "Aly";
            List<string> phones = new List<string>();
            phones.Add("01111111111");
            phones.Add("01222222222");
            phones.Add("088888888888888");

            empDetials.Slaray = salary;
            empDetials.Neckname = nekname;
            empDetials.Phone = phones;

            empDetials.Name = emp.Name;
            empDetials.Id = emp.Id;
            empDetials.Image = emp.Image;
            empDetials.Address = emp.Address;

            empDetials.DepartmentName = dept.Name;
            empDetials.DepartmentCode = dept.Code;

            return View("Detials", empDetials);




        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = DeparmentService.GetAllDepartments();
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(createupadteemployee employee)
        {

            // name not save in db 
            //
            //

            // mo

            if(employee.Name == "Aliiiiii")
            {
                ModelState.AddModelError("Name", "Please select a others  Ali.");
            }


            if (ModelState.IsValid==true)
            {

                //new employee
                // add it to database

                var Newemp = new Employee();   
                Newemp.Name = employee.Name;
                Newemp.Image = employee.Image;
                Newemp.Address = employee.Address;
                Newemp.Phone = employee.Phone;
                Newemp.DepartmentId = employee.DepartmentId;


                EmployeeService.Add(Newemp);
                return RedirectToAction("Index");
            }
            else
            {
                
                ViewBag.Departments = DeparmentService.GetAllDepartments();
                return View("Create", employee);
            }







            //if (employee.Name != null && employee.DepartmentId > 0&&employee.Phone!=null&&employee.Address!=null)
            //{
            //    EmployeeService.Add(employee);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    string errors = "";

            //    if (employee.Name == null)
            //        errors += "Name Must be not null \n";

            //    if (employee.DepartmentId <= 0)
            //        errors += "DepartmentId Must be valid \n";

            //    ViewBag.Error = errors;
            //    ViewBag.Departments = DeparmentService.GetAllDepartments();
            //    return View("Create", employee);
            //}
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = EmployeeService.GetEmployeeById(id);


            var editemp = new createupadteemployee();
            editemp.Id = emp.Id;
            editemp.Name = emp.Name;
            editemp.Image = emp.Image;
            editemp.Address = emp.Address;
            editemp.Phone = emp.Phone;
            editemp.DepartmentId = emp.DepartmentId;



            ViewBag.Departments = DeparmentService.GetAllDepartments();
            return View("Edit", editemp);
        }

        [HttpPost]
        public IActionResult Edit(createupadteemployee employee)
        {

            if (ModelState.IsValid == true)
            {

                //new employee
                // add it to database

                var Newemp = new Employee();
                Newemp.Name = employee.Name;
                Newemp.Image = employee.Image;
                Newemp.Address = employee.Address;
                Newemp.Phone = employee.Phone;
                Newemp.DepartmentId = employee.DepartmentId;


                EmployeeService.Update(Newemp);
                return RedirectToAction("Index");
            }
            else
            {

                ViewBag.Departments = DeparmentService.GetAllDepartments();
                return View("Edit", employee);
            }


            //if (employee.Name != null && employee.DepartmentId > 0)
            //{
            //    EmployeeService.Update(employee);
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    string errors = "";

            //    if (employee.Name == null)
            //        errors += "Name Must be not null \n";

            //    if (employee.DepartmentId <= 0)
            //        errors += "DepartmentId Must be valid \n";

            //    ViewBag.Error = errors;
            //    ViewBag.Departments = DeparmentService.GetAllDepartments();
            //    return View("Edit", employee);
            //}
        }

        public IActionResult Delete(int id)
        {
            EmployeeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}