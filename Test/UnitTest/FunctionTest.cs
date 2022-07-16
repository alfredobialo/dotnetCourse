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
        string data = "I am a Boy";
        string expectation = "I Am A Boy";

        string titleCased = Functions.TitleCase(data);
        
        _writer.WriteLine($"TitleCase func: Expected : {expectation}, Actual value: {titleCased}");
        
        Assert.Equal(expectation, titleCased);
    }
}
