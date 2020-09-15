using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] arrChar = input.ToCharArray();
        Array.Reverse(arrChar);
        string invertida = new String(arrChar);

        return invertida;
    }
}