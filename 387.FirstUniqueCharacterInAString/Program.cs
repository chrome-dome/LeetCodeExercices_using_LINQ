//Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

using System;
using System.Linq;

class MainClass
{
    public static char? FirstNonRepeatingChar(string s)
    {
        var nonRepeatingChar = s.GroupBy(c => c)
        .Where(g => g.Count() == 1)
        .Select(g => g.Key)
        .FirstOrDefault();
        return nonRepeatingChar;
    }

public static void Main(string[] args)
    {
        string s = "leetcode";
        var index = s.IndexOf((char)FirstNonRepeatingChar(s));
        if (index == -1)
        {
            Console.WriteLine("There is no non-repeating character in the string.");
        }
        else
        {
            Console.WriteLine("The first non-repeating character is at index " + index);
        }
        Console.ReadLine();
    }
}
