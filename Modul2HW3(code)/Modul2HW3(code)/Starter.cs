using System;

public class Starter
{
    public static void Run()
    {
        var candy = new CandyProvider();

        var present = new Present(candy.GetCandies());

        var weightPresent = new PresentServiсe().GetWeightPresent(present.Candies);

        foreach (var i in present.Candies)
        {
            Console.Write($"{i.Weight.Value} ");
        }

        Console.WriteLine();

        var sortCandies = new PresentServiсe().ArraySort(present.Candies);

        foreach (var i in sortCandies)
        {
            Console.Write($"{i.Weight.Value} ");
        }

        Console.WriteLine();

        // количество шоколадок по калориям = 15
        var counterChocolate = new PresentServiсe().GetCandy(present.Candies, new Chocolate { СalorieСontent = 15 });

        // количество карамелек по калориям = 56
        var counterCaramel = new PresentServiсe().GetCandy(present.Candies, new Caramel { СalorieСontent = 56 });

        Console.WriteLine(counterChocolate);
        Console.WriteLine(counterCaramel);

        Console.WriteLine($"Weight Present: {weightPresent}");
    }
}
