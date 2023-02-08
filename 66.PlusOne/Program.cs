//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.


int[] PlusOne(int[] digits)
{
    var newDigits = Enumerable.Range(1, digits.Length)
    .Reverse()
    .Select((i) => {
        if (digits[i - 1] < 9)
        {
            return digits[i - 1] + 1;
        }
        return 0;
    })
    .ToList();
    if (newDigits.Last() == 0)
    {
        newDigits[newDigits.Count - 1] = 1;
        newDigits.Add(0);
    }
    return newDigits.ToArray();
}

int[] digits = new int[] { 1, 2, 3 };
int[] result = PlusOne(digits);
foreach (int digit in result)
{
    Console.Write(digit);
}

Console.ReadLine();