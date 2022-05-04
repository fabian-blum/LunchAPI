namespace LunchAPI.Models
{
    public class Meal : BaseModel
    {
        public IEnumerable<Ingredients>? Ingredients { get; set; }
    }
}
