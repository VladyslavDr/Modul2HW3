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

        // Console.WriteLine($"Weight Present: {weightPresent}");
    }
}
