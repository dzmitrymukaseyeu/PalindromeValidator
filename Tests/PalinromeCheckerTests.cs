using PalindromeValidator;
namespace Tests;

public class PalinromeCheckerTests
{
    private static PalindromChecker checker = new();

    [Fact]
    public void When_Palindrome_ReturnTrue()
    {
        var (result, errorMessage) = checker.IsPalindrome("level");
        Assert.True(result);
        Assert.Null(errorMessage);
    }

    [Fact]
    public void When_Not_Palindrome_ReturnFalse()
    {
        var (result, errorMessage) = checker.IsPalindrome("palindrome");
        Assert.False(result);
        Assert.Null(errorMessage);
    }

    [Fact]
    public void When_Empty_String_ReturnError()
    {
        var (result, errorMessage) = checker.IsPalindrome("");
        Assert.False(result);
        Assert.Equal("Value should not be empty", errorMessage);
    }

    [Fact]
    public void When_More_Than_12_Characters_ReturnError()
    {
        var (result, errorMessage) = checker.IsPalindrome("veryveryverylongstring");
        Assert.False(result);
        Assert.Equal("Value cannot be more than 12 characters", errorMessage);
    }
}