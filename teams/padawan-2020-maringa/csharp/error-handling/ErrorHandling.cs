using System;
using System.Text.RegularExpressions;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if (Regex.IsMatch(input, @"\d"))
            return 1;
        return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        //if (Regex.IsMatch(input, @"\d")) {
        //    result = Convert.ToInt32(input);
        //return true; }

        //result = 0;
        //return false;

        try
        {
            result = Convert.ToInt32(input);
            return true;
        }
        catch
        {
            result = 0;
            return false;
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            throw new Exception();
        }
        finally
        {
            disposableObject.Dispose();
        }
    }
}
