using PalindromeValidator;
namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Add_Palindrome_ReturnTrue()
    { 
        var (result, errorMessage) = PalindromeChecker.isPalindrome("level");
        Assert.True(result);
        Assert.Null(errorMessage);
    }
    
    [Fact]
    public void Add_Not_Palindrome_ReturnFalse()
    { 
        var (result, errorMessage) = PalindromeChecker.isPalindrome("palindrome");
        Assert.False(result);
        Assert.Null(errorMessage);
    }
    
    [Fact]
    public void Add_Empty_String_ReturnError()
    { 
        var (result, errorMessage) = PalindromeChecker.isPalindrome("");
        Assert.False(result);
        Assert.Equal("Value should not be empty", errorMessage);
    }
    
    [Fact]
    public void Add_More_Than_12_Characters_ReturnError()
    { 
        var (result, errorMessage) = PalindromeChecker.isPalindrome("veryveryverylongstring");
        Assert.False(result);
        Assert.Equal("Value cannot be more than 12 characters", errorMessage);
    }
}