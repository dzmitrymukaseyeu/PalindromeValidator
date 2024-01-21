using PalindromeValidator;

var reader = new ConsoleReader();
var checker = new PalindromChecker();
var printer = new ConsoleWriter();

var inputValue = reader.Read();
var (isPalindrome, error) = checker.IsPalindrome(inputValue);
printer.Print(error ?? GetSuccessMessage(isPalindrome, inputValue));

string GetSuccessMessage(bool isPalindrome, string value) =>
    isPalindrome ? $"{value} is palindrome" : $"{value} is not palindrome";