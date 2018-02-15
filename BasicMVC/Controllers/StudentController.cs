using BasicMVC.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BasicMVC.Controllers
{
    public class StudentController : Controller
    {
        private string BaseUrl = "http://localhost:59568/";
        public async Task<ActionResult> Index()
        {
            List<Student> studentInfo = new List<Student>();
            using (var client = new HttpClient())
            {
                //passing service base url 
                client.BaseAddress = new System.Uri(BaseUrl);
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage response = await client.GetAsync("api/student");
                //Checking the response is successful or not which is sent using HttpClient  
                if (response.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var studentResponse = response.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list 
                    studentInfo = JsonConvert.DeserializeObject<List<Student>>(studentResponse);
                }
            }

            return View(studentInfo);
        }
    }
}