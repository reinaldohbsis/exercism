using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> jorginho = new List<int>();
        int produto = 0;

        foreach (var item in multiples)
        {
            for(int t = 0; t < max; t++)
            {
                if (item == 0)
                    jorginho.Add(0);
                else if (t % item == 0)
                    jorginho.Add(t);
            }
        }

        var martelo = jorginho.Distinct().ToList();
        int retorno = 0;

        foreach(var item in martelo)
        {
            retorno += item;
        }
        return retorno;

        //List<int> valores = new List<int>();
        //var sum = 0;
        //foreach (int numero in multiples)
        //{
        //    for (int i = 0; i < max; i++)
        //    {
        //        if (numero == 0)
        //        {
        //            valores.Add(0);
        //        }
        //        else if (i % numero == 0)
        //        {
        //            valores.Add(i);
        //        }
        //    }
        //}
        //var valorsemrepeticao = valores.Distinct().ToList();
        //foreach (var valor in valorsemrepeticao)
        //{
        //    sum += valor;
        //}
        //return sum;
    }
}