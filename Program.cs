using System.Text;

namespace SimpleMenu;

public class Program
{
    private static readonly Dictionary<string, string[]> _foodCategories
        = new()
        {
            { "starters", new[] { "dumplings", "peanuts", "bread", "salad" } },

            {
                "mains",
                new[] { "steak", "bento", "chicken", "pizza",
                    "sandwich", "taco", "sushi", "burger",
                    "hotdog", "pasta", "wrap", "rice" }
            },

            {
                "desserts",
                new[] { "apples", "strawberries", "cheese",
                    "icecream", "pie", "cake" }
            }
        };

    private static readonly string[] _chefDishes
        = { "strawberries", "dumplings", "pasta",
            "rice", "apples", "salad", "peanuts",
            "cheese", "bento", "sushi" };

    static void Main(string[] args)
    {
        var starters = new List<string>(0);
        var mains = new List<string>(0);
        var desserts = new List<string>(0);

        var originalStarterDictionary = _foodCategories["starters"];
        var originalMainsDictionary = _foodCategories["mains"];
        var originalDessertDictionary = _foodCategories["desserts"];

        starters.AddRange(originalStarterDictionary.Where(s => _chefDishes.Contains(s)));

        mains.AddRange(originalMainsDictionary.Where(s => _chefDishes.Contains(s)));

        desserts.AddRange(originalDessertDictionary.Where(s => _chefDishes.Contains(s)));

        Console.WriteLine("==== Just Falafs ====");
        Console.WriteLine("~ Menu ~");

        Console.WriteLine("Starters");

        var stringBuilder = new StringBuilder();
        for (var index = 0; index < starters.Count; index++)
        {
            var starter = starters[index];
            if (index + 2 <= starters.Count)
            {
                var value = $"{starter}, ";
                stringBuilder.Append(value);
            }

            if (index + 1 == starters.Count)
            {
                var value = $"or {starter}";
                stringBuilder.Append(value);
            }
        }
        Console.WriteLine(stringBuilder);

        Console.WriteLine("Mains");
        var mainsStringBuilder = new StringBuilder();
        for (var index = 0; index < mains.Count; index++)
        {
            var main = mains[index];
            if (index + 2 <= mains.Count)
            {
                var value = $"{main}, ";
                mainsStringBuilder.Append(value);
            }
            if (index + 1 == mains.Count)
            {
                var value = $"or {main}";
                mainsStringBuilder.Append(value);
            }
        }
        Console.WriteLine(mainsStringBuilder);

        Console.WriteLine("Desserts");
        var dessertsStringBuilder = new StringBuilder();
        for (var index = 0; index < desserts.Count; index++)
        {
            var dessert = desserts[index];
            if (index + 2 <= desserts.Count)
            {
                var value = $"{dessert}, ";
                dessertsStringBuilder.Append(value);
            }
            if (index + 1 == desserts.Count)
            {
                var value = $"or {dessert}";
                dessertsStringBuilder.Append(value);
            }
        }
        Console.WriteLine(dessertsStringBuilder);
    }
}
