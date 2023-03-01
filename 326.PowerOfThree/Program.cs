//Given an integer n, return true if it is a power of three. Otherwise, return false.

//An integer n is a power of three, if there exists an integer x such that n == 3x.


using System.Linq;

bool IsPowerOfThree(int n)
{
    return (n > 0) && Enumerable.Range(1, int.MaxValue)
    .Select(x => (int)Math.Pow(3, x))
    .TakeWhile(x => x <= n)
    .Contains(n);
}

Console.WriteLine(IsPowerOfThree(27)); // Output: true
Console.WriteLine(IsPowerOfThree(81)); // Output: true
Console.WriteLine(IsPowerOfThree(4)); // Output: false

Console.ReadLine();