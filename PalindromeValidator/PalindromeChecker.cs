namespace PalindromeValidator;

public class PalindromChecker
{
    public (bool success, string? errorMessage) IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return (false, "Value should not be empty");
        }

        if (text.Length > 12)
        {
            return (false, "Value cannot be more than 12 characters");
        }

        var reversedText = ReverseString(text.ToLower());

        return (text == reversedText, null);
    }

    private string ReverseString(string value)
    {
        var charArray = value.ToCharArray();
        Array.Reverse(charArray);
        var reversedValue = new string(charArray);

        return reversedValue;
    }
}