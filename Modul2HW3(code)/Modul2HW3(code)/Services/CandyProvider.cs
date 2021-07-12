using System;
public class CandyProvider : ICandyProvider
{
    private static readonly Candy[] _candy;

    static CandyProvider()
    {
        _candy = new Candy[]
        {
            new Caramel
            {
                Name = "text1",
                Form = FormType.Rhombus, СalorieСontent = 125,
                Weight = new Weight { Value = 78, Unit = UnitWeight.Grams },
                AmountOfSugar = new Weight { Value = 32, Unit = UnitWeight.Grams }
            },

            new Chocolate
            {
                Name = "Milca",
                Type = ChocolateType.Dark,
                AmountOfSugar = new Weight { Value = 250, Unit = UnitWeight.Grams },
                СalorieСontent = 356,
                Weight = new Weight { Value = 3, Unit = UnitWeight.Grams },
                ColorCandyWrapper = ColorCandyWrapperType.Green
            },

            new Chocolate
            {
                Name = "Roshen++",
                Type = ChocolateType.White,
                AmountOfSugar = new Weight { Value = 10, Unit = UnitWeight.Grams },
                СalorieСontent = 658,
                Weight = new Weight { Value = 9, Unit = UnitWeight.Grams },
                ColorCandyWrapper = ColorCandyWrapperType.Green
            },

            new Caramel
            {
                Name = "sdg",
                Weight = new Weight { Value = 12, Unit = UnitWeight.Grams },
                AmountOfSugar = new Weight { Value = 10, Unit = UnitWeight.Grams },
                Form = FormType.Cock,
                СalorieСontent = 356,
                ColorCandyWrapper = ColorCandyWrapperType.Blue
            }
        };
    }

    public Candy[] GetCandies()
    {
        return _candy;
    }
}
