using API_Imitation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test.Models;

namespace Test.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ILogger<RatingsController> _logger;
        private IRepository<RatingsRepository> _repository;

        public RatingsController(ILogger<RatingsController> logger, IRepository<RatingsRepository> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var request = await _repository.Get();
            var records = JsonConvert.DeserializeObject<RatingsModel>(request);
            return View(records);
        }
    }
}
