using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string retorno = "";


        if(number % 3 == 0)
        {
            retorno += "Pling";
        }
       if(number % 5 == 0)
        {
            retorno += "Plang";
        }
        if(number % 7 == 0)
        {
            retorno += "Plong";
        }
        if(retorno == "")
        {
            retorno += number.ToString();
        }

        return retorno;
    }
}