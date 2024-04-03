using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SubApi.Models;
using System.Text;
using System.Text.Json.Serialization;

namespace Assignment.Controllers
{
    public class SubscribeController(HttpClient http) : Controller
    {
        private readonly HttpClient _http = http;

        [HttpPost]
        public async Task <IActionResult> Subscribe(SubscribeForm form)
        {
            if (ModelState.IsValid)
            {
                var content =new StringContent(JsonConvert.SerializeObject(form), Encoding.UTF8,"application/json");
                var response = await _http.PostAsync("https://localhost:7295/api/subscribe", content);
                if (response.IsSuccessStatusCode)
                {
                    TempData["status"] = "Your are ur new subscriber,thank you so much:)";

                    return RedirectToAction("Home", "Default", "subscribe");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict) 
                {

                    TempData["status"] = "Your are already a subscriber ! ";
                    return RedirectToAction("Home", "Default", "subscribe");
                }

            }

            TempData["status"] = "Something went wrong .)";
            return RedirectToAction("Home", "Default", "subscribe");
        }
    }
}
