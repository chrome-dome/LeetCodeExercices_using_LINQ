//Reverse bits of a given 32 bits unsigned integer.

using System;
using System.Linq;

class ReverseBits
{
    static void Main(string[] args)
    {
        uint n = 43261596; //00000010100101000001111010011100
        uint reversed = ReverseBitsHelper(n);
        Console.WriteLine("Original: {0}", n);
        Console.WriteLine("Reversed: {0}", reversed);
        Console.ReadLine();
    }

static uint ReverseBitsHelper(uint n)
    {
        return Convert.ToUInt32(String.Concat(Convert.ToString(n, 2).PadLeft(32, '0').Reverse()), 2);
    }
}

