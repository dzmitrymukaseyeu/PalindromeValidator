namespace PalindromeValidator;

public class PalindromChecker
{
    public static (bool success, string? errorMessage) isPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return (false, "Value should not be empty");
        }

        if (text.Length > 12)
        {
            return (false, "Value cannot be more than 12 characters")
            }

        var reversedText = ReverseString(text.ToLower());

        return (text == reversedText, null);
    }

    private static string ReverseString(string value)
    {
        var charArray = value.ToCharArray();
        Array.Reverse(charArray);
        var reversedValue = new string(charArray);

        return reversedValue;
    }
}