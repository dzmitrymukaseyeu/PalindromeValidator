using PalindromeValidator;

var checker = new PalindromChecker();

var inputValue = Read();
var (isPalindrom, error) = checker.IsPalindrom(inputValue);
Write(error ?? GetSuccessMessage(isPalindrom, inputValue));

string GetSuccessMessage(bool isPalindrom, string value) =>
    isPalindrom ? $"{value} is palindrom" : $"{value} is not palindrom";

string Read()
{
    Console.WriteLine("Enter value: ");
    return Console.ReadLine();
}

void Write(string result)
{
    Console.WriteLine(result);
}