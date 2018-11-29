using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Modelo;

namespace Portal.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index()
        {
            IEnumerable<EncuestaModel> encuestas = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60025/api/");
                var responseTask = client.GetAsync("Encuesta");
                responseTask.Wait();

                var result = responseTask.Result;
                  
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<EncuestaModel>>();
                    readTask.Wait();

                    encuestas = readTask.Result;
                }
                else
                {
                      
                    encuestas = Enumerable.Empty<EncuestaModel>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }






            return View(encuestas);
        }
    }
}