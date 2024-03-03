using API_Imitation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test.Models;

namespace Test.Controllers
{
    public class TotalChatsController : Controller
    {
        private readonly ILogger<TotalChatsController> _logger;
        private IRepository<TotalChatsRepository> _repository;

        public TotalChatsController(ILogger<TotalChatsController> logger, IRepository<TotalChatsRepository> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var request = await _repository.Get();
            var records = JsonConvert.DeserializeObject<TotalChatsModel>(request);
            return View(records);
        }
    }
}
