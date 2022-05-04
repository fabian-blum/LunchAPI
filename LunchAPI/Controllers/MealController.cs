using LunchAPI.Models;
using LunchAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunchAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {

        private readonly ILogger<MealController> _logger;
        private readonly IRepository<Meal> _mealRepository;

        public MealController(
            ILogger<MealController> logger,
            IRepository<Meal> mealRepository)
        {
            _logger = logger;
            _mealRepository = mealRepository;
        }

        // TODO use ActionResult to return 
        [HttpGet]
        public IEnumerable<Meal> GetAll()
        {
            _logger.LogInformation("All meals called");
            return _mealRepository.GetAll();
        }

        // TODO Add other CRUD Endpoints
    }
}