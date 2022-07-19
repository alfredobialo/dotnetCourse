using System.Globalization;
using System.Text;
using System.Xml;

namespace ApplicationLibrary;

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

    public static string TitleCase(string input)
    {
        string result = String.Empty;
        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            return result;

        input = input.ToLower().Trim();
        
        // split string using space as a seperator
        var splitedInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var s in splitedInput)
        {
            string temp = s.Trim();
            temp = temp[0].ToString().ToUpper() + temp.Substring(1);
            result += temp + " ";
        }
        
        return result.Trim();
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
