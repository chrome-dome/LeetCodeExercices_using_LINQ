//Given an integer n, return a string array answer (1-indexed) where:
//answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//answer[i] == "Fizz" if i is divisible by 3.
//answer[i] == "Buzz" if i is divisible by 5.
//answer[i] == i(as a string) if none of the above conditions are true.

class Solution
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        var result = s.FizzBuzz(15);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    public IEnumerable<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1, n).Select(i => i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
    }
}


