using ApplicationLibrary;
using Xunit.Abstractions;
using FluentAssertions;
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

    [Theory]
    [InlineData("Welcome", 4, "come")]
    [InlineData("Alfred Obialo", 6, "Obialo")]
    [InlineData("Effective Accounting Business Solution", 17, "Business Solution")]
    [InlineData("Ride IDE", 3, "IDE")]
    public void Right_Function_Should_Return_string(string content, int count, string expectation)
    {
        // Right(content,4) = come
        string result = Functions.RightString(content, count);
        _writer.WriteLine($"RightString({content}, {count}) should be : {expectation}, but Got: {result}");
        result.Should().NotBeEmpty().And.NotBeNull().And.Be(expectation);
    } 
    
    [Theory]
    [InlineData("Welcome", 4, "Welc")]
    [InlineData("Alfred Obialo", 6, "Alfred")]
    [InlineData("Effective Accounting Business Solution", 17, "Effective Account")]
    [InlineData("Ride IDE", 3, "Rid")]
    public void Left_Function_Should_Return_string(string content, int count, string expectation)
    {
        // Left(content,4) = come
        string result = Functions.LeftString(content, count);
        _writer.WriteLine($"LeftString({content}, {count}) should be : {expectation}, but Got: {result}");
        result.Should().NotBeEmpty().And.NotBeNull().And.Be(expectation);
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
