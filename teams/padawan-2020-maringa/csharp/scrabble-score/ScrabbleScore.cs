using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int soma = 0;
        string v = input.ToUpper();
        for(int i = 0; i < v.Length; i++)
        {
            foreach(var item in Enum.GetValues(typeof(Gabarito)))
            {
                string a = item.ToString();
                for(int j = 0; j<a.Length; j++)
                {
                    if (a[j] == v[i])
                        soma += Convert.ToInt32(item);
                }
            }
        }
        return soma;

    }

    enum Gabarito
    {
        AEIOULNRST = 1,
        DG = 2,
        BCMP = 3,
        FHVWY = 4,
        K = 5,
        JX = 8,
        QZ = 10
    }
}