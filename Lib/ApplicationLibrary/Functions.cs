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

    public static string TitleCase(string str)
    {
        // if (str.Length == 0)
        // {
        //     return "Empty String";
        // }
        // else
        //     return char.ToUpper(str[0]) + str.Substring(1); 
        
        // string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        //
        // return titleCase;
        //
        
        str = str.ToLower();
        char[] array = str.ToCharArray();
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
        }
        return new string(array);
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
