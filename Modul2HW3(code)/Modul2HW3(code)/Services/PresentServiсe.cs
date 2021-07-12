using System;

public class PresentServiсe : IPresentService
{
    private int _weight = 0;

    public int GetWeightPresent(Candy[] candies)
    {
        foreach (var candy in candies)
        {
            _weight += candy.Weight.Value;
        }

        return _weight;
    }

    public Candy[] ArraySort(Candy[] candies)
    {
        Array.Sort(candies, new CandyComparer());

        return candies;
    }

    public int GetCandy(Candy[] candies, Candy candy)
    {
        return candies.CandyCount(candy);
    }
}
