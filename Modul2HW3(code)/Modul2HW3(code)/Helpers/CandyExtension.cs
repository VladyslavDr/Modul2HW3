using System;
public static class CandyExtension
{
    public static int CandyCount(this Candy[] candies, Candy candy)
    {
        var counter = 0;

        for (var i = 0; i < candies.Length; i++)
        {
            if (candies[i].СalorieСontent == candy.СalorieСontent)
            {
                counter++;
            }
        }

        return counter;
    }
}
