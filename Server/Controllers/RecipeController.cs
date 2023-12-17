using Fridgelr.Server.Data;
using Fridgelr.Server.Services;
using Fridgelr.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fridgelr.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IOpenAIAPIService _openAiApiService;
        public RecipeController(IOpenAIAPIService openAiApiService)
        {
            _openAiApiService = openAiApiService;
        }

        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {
            string mealTime = recipeParms.MealTime;
            List<string> ingredients = recipeParms.Ingredients.Where(i => !string.IsNullOrEmpty(i.Description!))
                                                              .Select(i => i.Description!)
                                                              .ToList();

            if (string.IsNullOrEmpty(mealTime))
            {
                mealTime = "Breakfast";
            }

            var ideas = await _openAiApiService.CreateRecipeIdeas(mealTime, ingredients);

            return ideas;
        }
        
    }
}
