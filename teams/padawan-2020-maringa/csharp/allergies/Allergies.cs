using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private string _bin { get; set; }
    private readonly int Mask;

    public Allergies(int mask)
    {
        Mask = mask;       
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);
    }

    public Allergen[] List()
    {
        if (Mask == 0)
            return new Allergen[0];
        List<Allergen> jorgi = new List<Allergen>();
        string t = reverseString(Mask);
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == '1')
            {
                foreach (var item in Enum.GetValues(typeof(Allergen)))
                {
                    if (Convert.ToInt32(item) == Math.Pow(2, i))
                    {
                        jorgi.Add((Allergen)item);
                    }
                }
            }
        }
        return jorgi.ToArray();
    }

    public static string reverseString(int numi)
    {
        string Word = Convert.ToString(numi, 2);
        char[] arrChar = Word.ToCharArray();
        Array.Reverse(arrChar);
        string invertida = new String(arrChar);

        return invertida;
    }
}