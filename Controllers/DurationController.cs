using API_Imitation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test.Models;

namespace Test.Controllers
{
    public class DurationController : Controller
    {
        private readonly ILogger<DurationController> _logger;
        private IRepository<DurationRepository> _repository;

        public DurationController(ILogger<DurationController> logger, IRepository<DurationRepository> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var request = await _repository.Get();
            var records = JsonConvert.DeserializeObject<DurationModel>(request);
            return View(records);
        }
    }
}
