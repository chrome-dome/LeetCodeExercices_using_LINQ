/*
-Write a function to find the longest common prefix string amongst an array of strings.
-If there is no common prefix, return an empty string "".
 */

using System;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] strs = { "flower", "flow", "flight" };
        string lcp = solution.LongestCommonPrefix(strs);
        Console.WriteLine("Longest Common Prefix: " + lcp);
        Console.ReadLine();
    }

public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || !strs.Any())
        {
            return "";
        }

        int index = 0;
        string lcp = "";
        char[] firstString = strs.First().ToCharArray();
        foreach (var c in firstString)
        {
            if (strs.Skip(1).Any(s => index >= s.Length || s[index] != c))
            {
                return lcp;
            }
            lcp += c;
            index++;
        }
        return lcp;
    }
}
