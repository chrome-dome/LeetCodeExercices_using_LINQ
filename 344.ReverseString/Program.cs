//Write a function that reverses a string. The input string is given as an array of characters s.

//You must do this by modifying the input array in-place with O(1) extra memory.


//Version1 - 0(n)

char[] ReverseString(char[] s)
{
    return s.Reverse().ToArray();
}

char[] s = { 'h', 'e', 'l', 'l', 'o' };
Console.WriteLine(ReverseString(s));

Console.ReadLine();

