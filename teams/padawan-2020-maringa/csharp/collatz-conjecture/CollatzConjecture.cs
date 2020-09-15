using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        if (number == 1)
            return 0;

        int val = number;        
        int passos = 0;

        while (val != 1)
        {
            if(val % 2 == 0)
            {
                val = (val / 2);
                passos++;
            }
            else
            {
                val = ((val * 3) + 1);
                passos++;
            }
           // passos += (val % 2 == 0) ? : ((val * 3) + 1);
        }
        return passos;
    }
}