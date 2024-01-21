using PalindromeValidator;
using Xunit;
namespace Tests;

public class PalindromCheckerTests
{
    private static PalindromChecker checker = new();

    [Fact]
    public void When_Palindrome_ReturnTrue()
    {
        var (result, errorMessage) = checker.IsPalindrom("level");
        Assert.True(result);
        Assert.Null(errorMessage);
    }

    [Fact]
    public void When_PalindromeWithWhiteSpaces_ReturnTrue()
    {
        var (result, errorMessage) = checker.IsPalindrom("level  ");
        Assert.False(result);
        Assert.Null(errorMessage);
    }

    [Fact]
    public void When_Not_Palindrome_ReturnFalse()
    {
        var (result, errorMessage) = checker.IsPalindrom("palindrome");
        Assert.False(result);
        Assert.Null(errorMessage);
    }

    [Fact]
    public void When_Empty_String_ReturnError()
    {
        var (result, errorMessage) = checker.IsPalindrom("");
        Assert.False(result);
        Assert.Equal("Value should not be empty", errorMessage);
    }

    [Fact]
    public void When_More_Than_12_Characters_ReturnError()
    {
        var (result, errorMessage) = checker.IsPalindrom("veryveryverylongstring");
        Assert.False(result);
        Assert.Equal("Value cannot be more than 12 characters", errorMessage);
    }
}