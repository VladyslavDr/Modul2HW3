using System;
public abstract class CandyProvider : ICandyInterface
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
                Weight = new Weight { Value = 125, Unit = UnitWeight.Grams },
                AmountOfSugar = new Weight { Value = 32, Unit = UnitWeight.Grams }
            },

            new Chocolate
            {
                Name = "Milca",
                Type = ChocolateType.Dark,
                AmountOfSugar = new Weight { Value = 250, Unit = UnitWeight.Grams },
                СalorieСontent = 356,
                Weight = new Weight { Value = 635, Unit = UnitWeight.Grams },
                ColorCandyWrapper = ColorCandyWrapperType.Green
            },

            new Chocolate
            {
                Name = "Roshen++",
                Type = ChocolateType.White,
                AmountOfSugar = new Weight { Value = 65, Unit = UnitWeight.Grams },
                СalorieСontent = 658,
                Weight = new Weight { Value = 688, Unit = UnitWeight.Grams },
                ColorCandyWrapper = ColorCandyWrapperType.Green
            },

            new Caramel
            {
                Name = "sdg",
                Weight = new Weight { Value = 475, Unit = UnitWeight.Grams },
                AmountOfSugar = new Weight { Value = 546, Unit = UnitWeight.Grams },
                Form = FormType.Cockerel,
                СalorieСontent = 356,
                ColorCandyWrapper = ColorCandyWrapperType.Blue
            }
        };
    }

    public static Candy[] GetCandies()
    {
        return _candy;
    }
}
