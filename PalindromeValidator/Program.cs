using PalindromeValidator;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

while (true)
{
    var inputValue = ReadValue.Read();
    var (isPalindrome, errorMessage) = PalindromeChecker.isPalindrome(inputValue);
    var result = errorMessage ?? (isPalindrome ? $"{inputValue} is palindrome" : $"{inputValue} is not palindrome");
    
    PrintResult.Print(result); 
}

app.Run();
