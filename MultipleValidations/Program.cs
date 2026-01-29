using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Enter a text to validate:");
string input = Console.ReadLine();

List<string> errors = Validate(input);

if (errors.Any())
{
    string finalErrors = string.Join("\n - ", errors);
    Console.WriteLine("\nErrors found:\n - " + finalErrors);
}
else
{
    Console.WriteLine("✔️ The string is valid");
}

List<string> Validate(string input)
{
    List<string> errors = new();

    if (string.IsNullOrWhiteSpace(input))
        errors.Add("The text cannot be empty.");

    if (input.Length < 5)
        errors.Add("It must have at least 5 characters.");

    if (!input.Any(char.IsUpper))
        errors.Add("It must include at least one uppercase letter.");

    if (!input.Any(char.IsLower))
        errors.Add("It must include at least one lowercase letter.");

    if (!input.Any(char.IsDigit))
        errors.Add("It must include at least one number.");

    return errors;
}
