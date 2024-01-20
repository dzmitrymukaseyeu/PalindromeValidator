namespace PalindromeValidatorTests;

public class UnitTest1
{
    [Fact]
    public void IsPalindrome_ShouldReturnTrue_ForPalindrome()
    {
        var checker = new PalindromeChecker();
        bool result = checker.IsPalindrome("level");
        Assert.True(result);
    }
}