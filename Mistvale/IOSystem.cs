using System;

public class IOSystem
{
	public IOSystem()
	{
	}

	public static String CreateMenuTwo(String option1, String option2)
	{
		Console.WriteLine("Would you like to: ");
		Console.WriteLine("1. " + option1);
		Console.WriteLine("2. " + option2);

		string choice = Console.ReadLine();

		while (true)
		{
			if (choice != "1" && choice != "2")
			{
				Console.WriteLine("Thats not a valid option. Please select \"1\" or \"2\" ");
				choice = Console.ReadLine();
			} else
			{
				break;
			}
		}
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------------------------");
        return choice;
	}

	public static void WaitForInput()
	{
		Console.WriteLine();
		Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------------------------");
    }

}

