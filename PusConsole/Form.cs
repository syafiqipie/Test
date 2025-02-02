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

	public static string AskMultipleChoices(string question, List<string> choices)
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

	public static int AskPositiveInteger(string question)
	{
		Console.WriteLine(question);
		string? input = Console.ReadLine();
		int number;
		while(input is null || !int.TryParse(input, out number) || number <= 0)
		{
			Console.WriteLine("Try again.");
			input = Console.ReadLine();
		}

		return number;
	}
}
