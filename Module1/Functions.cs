namespace Module1;

public static class Functions
{
    public static string ReverseString(string str)
    {
        string result = "";
        foreach (var s in str)  // Hello
        {
            result = s + result; // olleH
        }
        
        return result;
    }
}
