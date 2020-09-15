using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        int tam = numbers.Length;
        int mov = tam - sliceLength + 1;
        string num = numbers;
        string[] texto = new string[mov];

        if ((sliceLength < 0) || (numbers == "") || (numbers.Contains("-") == true) || (sliceLength == 0) || (mov < 1))
        {
            throw new ArgumentException();
        }

        if(mov == 1)
        {
            texto[0] = num;
            return texto;
        }
        
        for(int i = 0; i < mov; i++)
        {
            texto[i] = num.Substring(i, sliceLength);
        }

        return texto;
        
    }
}