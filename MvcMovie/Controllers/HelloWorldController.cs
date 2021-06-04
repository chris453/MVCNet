using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/  
        //user requests are routed to a controller 
        //which work with the model to perform user actions or queries
        //the conroller then choose the view to show the users based on request 
        //both the view and controller depend on the model but not backwards
        // every public method is a http endpoint 
        //business logic should be in the model 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1) // parameter numTimes =1 is default if not set in http
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }


    }
}