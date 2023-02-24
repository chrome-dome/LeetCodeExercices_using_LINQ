//Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

using System;
using System.Linq;

class ExcelColumns
{
    public static int ColumnTitleToNumber(string columnTitle)
    {
        return columnTitle.Aggregate(0, (result, current) => result * 26 + (current - 'A' + 1));
    }

public static void Main(string[] args)
    {
        Console.WriteLine(ColumnTitleToNumber("A")); // prints 1
        Console.WriteLine(ColumnTitleToNumber("B")); // prints 2
        Console.WriteLine(ColumnTitleToNumber("Z")); // prints 26
        Console.WriteLine(ColumnTitleToNumber("AA")); // prints 27
        Console.WriteLine(ColumnTitleToNumber("AB")); // prints 28
        Console.ReadLine();
    }
}
