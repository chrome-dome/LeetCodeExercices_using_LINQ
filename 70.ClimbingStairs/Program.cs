//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


//!!!This problem is a classic example of dynamic programming and can be solved using the Fibonacci sequence!!!


int ClimbStairs(int n)
{
    if (n <= 2) return n;

return Enumerable.Range(3, n - 2)
    .Aggregate(new List<int> { 1, 2 }, (acc, i) => {
        acc.Add(acc[i - 3] + acc[i - 2]);
        return acc;
    }).Last();
}

int steps = ClimbStairs(2);
Console.WriteLine(steps); // Output: 2

Console.ReadLine();
