//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

using System;
using System.Linq;

class Program
{
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sChars = s.OrderBy(c => c).ToArray();
        var tChars = t.OrderBy(c => c).ToArray();

        return sChars.SequenceEqual(tChars);
    }

    static void Main(string[] args)
    {
        string s = "anagram";
        string t = "nagaram";

        Console.WriteLine(IsAnagram(s, t));
        Console.ReadLine();
    }
}





