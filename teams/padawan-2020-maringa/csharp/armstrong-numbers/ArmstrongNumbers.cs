using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number == 0)
            return true;
        string num = Convert.ToString(number);
        double soma = 0;

        for (int i = 0; i < num.Length; i++)
        {
            soma += Math.Pow(Convert.ToInt32(num[i].ToString()), num.Length);
        }

        if (soma == number)
            return true;
        return false;
    }
}