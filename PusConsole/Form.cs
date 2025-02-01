using System.Diagnostics.CodeAnalysis;

public static class Form
{
	public static string AskNonEmptyString(string question)
	{
		Console.WriteLine(question);
		string? input = Console.ReadLine();
		while(string.IsNullOrEmpty(input))
		{
			Console.WriteLine("Try again.");
			input = Console.ReadLine();
		}
		
		return input!;
	}

	public static string AskMutlipleChoices(string question, List<string> choices)
	{
		Console.WriteLine(question);
		string? input = Console.ReadLine();
		while(input is null || !choices.Contains(input))
		{
			Console.WriteLine("Try again.");
			input = Console.ReadLine();
		}

		return input!;
	}

	public static int AskInteger(string question)
	{
		throw new NotImplementedException();
	}
}
