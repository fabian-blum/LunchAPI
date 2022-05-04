using Microsoft.AspNetCore.Mvc;

namespace LunchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        public IngredientController(ILogger<IngredientController> logger)
        {

        }

        // TODO Add other Crud Endpoints
    }
}
