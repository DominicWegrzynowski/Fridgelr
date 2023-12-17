using Fridgelr.Shared;

namespace Fridgelr.Server.Services
{
    public interface IOpenAIAPIService
    {
        Task<List<Idea>> CreateRecipeIdeas(string mealTime, List<string> ingredients);
    }
}
