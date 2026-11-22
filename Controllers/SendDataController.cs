using Microsoft.AspNetCore.Mvc;
using MVCProject849.Model_Views;

namespace MVCProject849.Controllers
{
    public class SendDataController : Controller
    {





        public IActionResult Index()
        {
            return View();
        }

        //opene page that will send data to backend



        // create new contoller test
        // create action (open view)
        // create view (form)
        // create recvied data
        // create view data
        public IActionResult SendData()
        {
            return View();
        }
        public IActionResult ReceiveData(senddata senddata ) ///
        {
            // take 
             //
           //
           //
            // Process the received data (e.g., save to database, perform calculations, etc.)
            // For demonstration purposes, we'll just pass the data to a view.
            ViewBag.Name = senddata.name;
            ViewBag.Email = senddata.email;
            ViewBag.Age = senddata.age;
            ViewBag.Address = senddata.address;
            ViewBag.Phone = senddata.phone;

            return View("DisplayData");
        }

        //create action for open page that will send data to backend (view => form)
        //create action method that will receive data from frontend

    }
}
