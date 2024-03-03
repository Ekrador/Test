using API_Imitation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using Test.Models;

namespace Test.Controllers
{
    public class TagsController : Controller
    {
        private readonly ILogger<TagsController> _logger;
        private IRepository<TagsRepository> _repository;

        public TagsController(ILogger<TagsController> logger, IRepository<TagsRepository> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var request = await _repository.Get();
            var records = JsonConvert.DeserializeObject<TagModel>(request);
            return View(records);
        }
    }
}
