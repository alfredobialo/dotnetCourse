using ApplicationLibrary;
using Xunit.Abstractions;

namespace UnitTest;

public class FunctionTest
{
    private readonly ITestOutputHelper _writer;

    public FunctionTest(ITestOutputHelper writer)
    {
        _writer = writer;
    }
    [Fact]
    public void ReverseStringFunc_Should_Reverse_Any_Given_String()
    {
        // Arrange
        string data = "I am a Boy";
        string expectation = "yoB a ma I";

        // ACT
        string reversedStr = Functions.ReverseString(data); 


        // ASSERT
        Assert.Equal(expectation, reversedStr);
        
    }

    [Fact]
    public void TitleCaseFunc_Should_TitleCase_Any_Given_String()
    {
        string data = "I am a Boy but nOt a girl or     laDY";
        string expectation = "I Am A Boy But Not A Girl Or Lady";

        string titleCased = Functions.TitleCase(data);
        
        _writer.WriteLine($"TitleCase func: Expected : {expectation}, Actual value: {titleCased}");
        
        Assert.Equal(expectation, titleCased);
    }


    private string ToTitleCase(string input)
    {
        string result = String.Empty;
        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            return result;

        input = input.ToLower().Trim();
        
        // split string using space as a seperator
        var splitedInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        
        // If splittedInput[2] = "  Lady";   = "  Lady"

        foreach (var s in splitedInput)
        {
            string temp = s.Trim();
            temp = temp[0].ToString().ToUpper() + temp.Substring(1);
            result += temp + " ";
        }
        
        return result.Trim();
    }
}
