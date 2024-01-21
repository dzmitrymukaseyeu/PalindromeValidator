using PalindromeValidator;

while (true)
{
    var inputValue = ReadValue.Read();
    var (isPalindrome, errorMessage) = PalindromeChecker.isPalindrome(inputValue);
    var result = errorMessage ?? (isPalindrome ? $"{inputValue} is palindrome" : $"{inputValue} is not palindrome");
    
    PrintResult.Print(result); 
}