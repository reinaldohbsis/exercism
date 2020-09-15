using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToUpper();
        for(int i = 65; i <= 90; i++)
        {
            if (!input.Contains((char)i))
                return false;

        }
        return true;
    }
}
