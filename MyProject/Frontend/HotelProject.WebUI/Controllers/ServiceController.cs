using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.ServiceDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMapper _mapper;
        public ServiceController(IHttpClientFactory httpClientFactory,IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5210/api/Service");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultServiceDTO>>(jsonData);
              
                
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(CreateServiceDTO createServiceDTO)
        {
            var client=_httpClientFactory.CreateClient();
            var data=JsonConvert.SerializeObject(createServiceDTO);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5210/api/Service", content);
            if( responseMessage.IsSuccessStatusCode ) {
            return RedirectToAction("Index");
            }
            return View(createServiceDTO);
        }
        public async Task<IActionResult> DeleteService(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5210/api/Service?id={id}");
            if( responseMessage.IsSuccessStatusCode )
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5210/api/Service/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<UpdateServiceDTO>(jsonData);
                return View(model);
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDTO model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5210/api/Service/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}
