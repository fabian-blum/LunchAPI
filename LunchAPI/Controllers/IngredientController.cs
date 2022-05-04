using Microsoft.AspNetCore.Mvc;

namespace LunchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        // TODO Inject Repository to access data
        public IngredientController(ILogger<IngredientController> logger)
        {

        }

        // TODO Add other CRUD Endpoints
    }
}
