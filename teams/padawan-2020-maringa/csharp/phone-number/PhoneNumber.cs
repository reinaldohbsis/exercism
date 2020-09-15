using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string retorno = Regex.Replace(phoneNumber, @"\D","");
        if (retorno[0] == '1')
            retorno = retorno.Substring(1);
        var valido = Regex.IsMatch(retorno, @"^[2-9][0-9]{2}[2-9][0-9]{6}$");
        if (!valido)
            throw new ArgumentException();
        // retorno.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace(".", "");
        
        return retorno;
    }
}