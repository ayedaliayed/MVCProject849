using Microsoft.AspNetCore.Mvc;
using MVCProject849.Models;
using MVCProject849.Services;

namespace MVCProject849.Controllers
{
    public class DeparmnetController : Controller
    {
            
        DeparmentService deparmentService = new DeparmentService();

        public IActionResult Index()
        {
            //list of deparment
            var deparments = deparmentService.GetAllDepartments();
            //sent to view
            //create view for deparment
            //crerate deparment view folder
            //create index view for deparment
            //display deparment list in table

            return View("Index", deparments);

        }

        public IActionResult getbyid(int id)
        {

            var deparment = deparmentService.GetDepartmentById(id);

            return View("Details", deparment);
        }

        // step 1
        public IActionResult Add()
        {
            //step 2
            return View("Add", new Department());
        }
        // step 3
        public IActionResult Create(Department department)
        {
            //step 4
            if(department.Name != null && department.MangerName != null && department.Code != null)
            {
                deparmentService.Add(department);
                return RedirectToAction("Index");
            }
            else
            {
                string errors = "";

                if (department.Name == null)
                    errors += "Name Must be not null";

                if (department.MangerName == null)
                    errors += "MangerName Must be not null";

                if (department.Code == null)
                    errors += "Code Must be not null";


                ViewBag.Error = errors;
                return View("Add", department);
            }
            

       
        }

        public IActionResult Edit(int id)
        {
            var dept=deparmentService.GetDepartmentById(id);
            // get dep from dataabse
            return View("Edit", dept);
        }
        // step 3
        public IActionResult SaveEdit(Department department)
        {
            //step 4
            if (department.Name != null && department.MangerName != null && department.Code != null)
            {
                deparmentService.Update(department);
                return RedirectToAction("Index");
            }
            else
            {
                string errors = "";

                if (department.Name == null)
                    errors += "Name Must be not null \n";

                if (department.MangerName == null)
                    errors += "MangerName Must be not null \n";

                if (department.Code == null)
                    errors += "Code Must be not null";


                ViewBag.Error = errors;
                return View("Edit", department);
            }



        }

        #region test 
        //public IActionResult Create()
        //{
        //    return View("Create");
        //}

        //[HttpPost]
        //public IActionResult Create(Models.Department department)
        //{
        //    deparmentService.Add(department);

        //    return RedirectToAction("Index");
        //}

        //public IActionResult Edit(int id)
        //{
        //    var deparment = deparmentService.GetDepartmentById(id);

        //    if (deparment == null)
        //    {
        //        return NotFound();
        //    }

        //    return View("Edit", deparment);
        //}

        //[HttpPost]
        //public IActionResult Edit(Models.Department department)
        //{
        //    deparmentService.Update(department);

        //    return RedirectToAction("Index");
        //}

        #endregion

        public IActionResult Delete(int id)
        {

            deparmentService.Delete(id);

            return RedirectToAction("Index");
        }


    }
}
