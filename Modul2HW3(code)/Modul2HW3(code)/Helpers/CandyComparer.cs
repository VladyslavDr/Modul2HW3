using System;
using System.Collections.Generic;

public class CandyComparer : IComparer<Candy>
{
    public int Compare(Candy candy1, Candy candy2)
    {
        if (candy1.Weight.Value > candy2.Weight.Value)
        {
            return 1;
        }
        else if (candy1.Weight.Value < candy2.Weight.Value)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
