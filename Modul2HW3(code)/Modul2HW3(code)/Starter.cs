using System;

public class Starter
{
    public static void Run()
    {
        var candy = new CandyProvider();

        var present = new Present(candy.GetCandies());

        var weightPresent = new PresentServiсe().GetWeightPresent(present.Candies);

        Console.WriteLine($"the weight of each candy in the gift: ");

        foreach (var item in present.Candies)
        {
            Console.Write($"{item.Weight.Value} ");
        }

        Console.WriteLine();
        Console.WriteLine($"ArraySort sorting by weight of candies: ");

        var sortCandies = new PresentServiсe().ArraySort(present.Candies);

        foreach (var item in sortCandies)
        {
            Console.Write($"{item.Weight.Value} ");
        }

        Console.WriteLine();

        // количество шоколадок по калориям = 15
        var counterChocolate = new PresentServiсe().GetCandy(present.Candies, new Chocolate { СalorieСontent = 15 });

        // количество карамелек по калориям = 56
        var counterCaramel = new PresentServiсe().GetCandy(present.Candies, new Caramel { СalorieСontent = 56 });

        Console.WriteLine($"counter Chocolate width СalorieСontent = 15 in Present: {counterChocolate}");
        Console.WriteLine($"counter Caramel width СalorieСontent = 56 in Present: {counterCaramel}");

        Console.WriteLine($"Weight All Candies in Present: {weightPresent}");
    }
}
