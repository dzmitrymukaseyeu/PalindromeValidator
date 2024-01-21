using PalindromeValidator;

var checker = new PalindromChecker();

var inputValue = Read();
var (isPalindrome, error) = checker.IsPalindrome(inputValue);
Write(error ?? GetSuccessMessage(isPalindrome, inputValue));

string GetSuccessMessage(bool isPalindrome, string value) =>
    isPalindrome ? $"{value} is palindrom" : $"{value} is not palindrom";

string Read()
{
    Console.WriteLine("Enter value: ");
    return Console.ReadLine();
}

void Write(string result)
{
    Console.WriteLine(result);
}