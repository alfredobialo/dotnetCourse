using System.Text;

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

    public static string TitleCase(string str)
    {
        if (str.Length == 0)
        {
            return "Empty String";
        }
        else
            return char.ToUpper(str[0]) + str.Substring(1); 
    }

    public static string SnakeCase(string str)
    {
        var builder = new StringBuilder();

        int count = 0;
        foreach (var s in str)
        {
            builder.Append(s);
            if(count > 0)
            {
                builder.Append('-');
            }
        }

        return str;
    }
}
