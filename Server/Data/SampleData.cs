using Fridgelr.Shared;

namespace Fridgelr.Server.Data
{
    public class SampleData
    {
        public static List<Idea> RecipeIdeas = new()
        {
            new Idea
            {
                index = 0,
                Title = "Chocolate Chip Cookies",
                Description = "Delicious chocolate chip cookies made with browned butter"
            },
            new Idea
            {
                index = 1,
                Title = "Peanut Butter Cookies",
                Description = "Cookies made with peanut butter and butterscotch chips. Yum!"
            },
            new Idea {
                index = 2,
                Title = "Snickerdoodles",
                Description = "Classic snickerdoodle cookies. The secret ingredient is cream of tartar!"
            },
            new Idea {
                index = 2,
                Title = "Sugar Cookies",
                Description = "A sugar cookie is a cookie with the main ingredients being sugar, flour, butter, eggs, vanilla, and either baking powder or baking soda."
            },
            new Idea {
                index = 2,
                Title = "Ginger Snaps",
                Description = "Ginger snaps are a classic favorite. With just a few ingredients and even fewer steps this recipe for fabulous, spicy cookies is truly a snap to make."
            },
        };
    }
}
