//Given a roman numeral, convert it to an integer.

using System;
using System.Linq;
using System.Collections.Generic;

class RomanToInteger
{
    static Dictionary<char, int> RomanValues = new Dictionary<char, int>()
{
{'I', 1},
{'V', 5},
{'X', 10},
{'L', 50},
{'C', 100},
{'D', 500},
{'M', 1000}
};

static int RomanToInt(string s)
    {
        return s.Select((c, i) => i > 0 && RomanValues[c] > RomanValues[s[i - 1]] ? RomanValues[c] - 2 * RomanValues[s[i - 1]] : RomanValues[c]).Sum();
    }

    static void Main()
    {
        string s = "XII";
        Console.WriteLine(RomanToInt(s));
        Console.ReadLine();
    }
}
