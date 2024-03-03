using API_Imitation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test.Models;

namespace Test.Controllers
{
    public class ResponseTimeController : Controller
    {
        private readonly ILogger<ResponseTimeController> _logger;
        private IRepository<ResponseTimeRepository> _repository;

        public ResponseTimeController(ILogger<ResponseTimeController> logger, IRepository<ResponseTimeRepository> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var request = await _repository.Get();
            var records = JsonConvert.DeserializeObject<ResponseTimeModel>(request);
            return View(records);
        }
    }
}
