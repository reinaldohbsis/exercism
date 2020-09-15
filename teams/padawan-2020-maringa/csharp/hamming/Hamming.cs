using System;
using System.Collections.Specialized;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        throw new ArgumentException();
        int hd = 0;
        for(int i = 0 ; i < firstStrand.Length; i++)
        {
            hd += (firstStrand[i] != secondStrand[i] ? 1 : 0);
        }
        return hd;
    }
}