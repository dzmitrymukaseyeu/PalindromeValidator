namespace PalindromeValidator;

public class PalindromeChecker
{
   public static (bool success, string? errorMessage) isPalindrome(string text)
   {
       try
       {
           if (string.IsNullOrEmpty(text))
           {
               throw new ArgumentException("Value should not be empty"); 
           }

           if (text.Length > 12)
           {
               throw new ArgumentException("Value cannot be more than 12 characters"); 
           } 
       
           var reversedText = ReverseString(text.ToLower());
       
           return (text == reversedText, null);
       }
       catch (ArgumentException e)
       {
           return (false, e.Message);
       }
   }
   
    private static string ReverseString(string value)
    {   
        var charArray = value.ToCharArray();
        Array.Reverse(charArray);
        var reversedValue = new string(charArray);
        
        return reversedValue;
    }
}