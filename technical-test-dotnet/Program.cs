using System.Text.RegularExpressions;

string text = "A text       that            has      multiple     words     in    a technical test";

int count = CountWords(text);

Console.WriteLine(count);

int CountWords(string text)
{
    if (string.IsNullOrWhiteSpace(text))
        return 0;

    text = Regex.Replace(text, @"\s+", " ");

    text = text.Trim();

    var words = text.Split(' ');

    return words.Length;
}