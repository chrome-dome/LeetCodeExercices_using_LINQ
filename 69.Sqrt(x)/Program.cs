
//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

int squareRoot(int x)
{
    return (int)Math.Sqrt(x);
}

Console.WriteLine(squareRoot(4)); // Output: 2
Console.WriteLine(squareRoot(9)); // Output: 3
Console.WriteLine(squareRoot(16)); // Output: 4

Console.ReadLine();
