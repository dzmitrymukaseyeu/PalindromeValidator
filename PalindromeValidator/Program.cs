using PalindromeValidator;

var reader = new ConsoleReader();
var checker = new PalindromChecker();
var printer = new ConsoleWriter();

while (true)
{
    var inputValue = reader.Read();
    var (isPalindrome, errorMessage) = checker.IsPalindrome(inputValue);
    var result = errorMessage ?? (isPalindrome ? $"{inputValue} is palindrome" : $"{inputValue} is not palindrome");
    
    printer.Print(result); 
}