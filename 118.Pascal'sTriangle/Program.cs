//Given an integer numRows, return the first numRows of Pascal's triangle.

using System;
using System.Collections.Generic;
using System.Linq;

public class PascalTriangle
{
    public static IEnumerable<IEnumerable<int>> Generate(int numRows)
    {
        if (numRows == 0)
        {
            return Enumerable.Empty<IEnumerable<int>>();
        }

        return Enumerable.Range(1, numRows)
        .Select(i => Enumerable.Range(1, i)
            .Select(j => (j == 1 || j == i) ? 1 : Generate(i - 1).ElementAt(j - 1).ElementAt(j - 2) + Generate(i - 1).ElementAt(j - 1).ElementAt(j - 1)));
    }

    public static void Main(string[] args)
    {
        int numRows = 5;
        var triangle = PascalTriangle.Generate(numRows);

        foreach (var row in triangle)
        {
            Console.WriteLine(string.Join(" ", row));
        }
        Console.ReadLine();
    }
}


