using System;
using System.Collections.Generic;

public static class Etl
{

    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> nov = new Dictionary<string, int>();

        foreach(KeyValuePair<int,string[]> item in old)
        {
            for (int i = 0; i < item.Value.Length; i++)
            {
                if (item.Key == 1)
                    nov.Add(item.Value[i].ToString().ToLower(), 1);
                if (item.Key == 2)
                    nov.Add(item.Value[i].ToString().ToLower(), 2);
                if (item.Key == 3)
                    nov.Add(item.Value[i].ToString().ToLower(), 3);
                if (item.Key == 4)
                    nov.Add(item.Value[i].ToString().ToLower(), 4);
                if (item.Key == 5)
                    nov.Add(item.Value[i].ToString().ToLower(), 5);
                if (item.Key == 6)
                    nov.Add(item.Value[i].ToString().ToLower(), 6);
                if (item.Key == 7)
                    nov.Add(item.Value[i].ToString().ToLower(), 7);
                if (item.Key == 8)
                    nov.Add(item.Value[i].ToString().ToLower(), 8);
                if (item.Key == 9)
                    nov.Add(item.Value[i].ToString().ToLower(), 9);
                if (item.Key == 10)
                    nov.Add(item.Value[i].ToString().ToLower(), 10);
            }


        }

        return nov;



    }
}