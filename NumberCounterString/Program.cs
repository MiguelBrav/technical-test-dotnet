// Count numbers in a string

using System.Text.RegularExpressions;

string text = "There are 7 dogs, 25 cats, -5 invisible birds and 7 magic frogs";
int count = CountNumbers(text);

Console.WriteLine(count);

int CountNumbers(string text)
{
    if (string.IsNullOrWhiteSpace(text))
        return 0;

    MatchCollection matches = Regex.Matches(text, @"-?\d+");

    return matches.Count;
}
