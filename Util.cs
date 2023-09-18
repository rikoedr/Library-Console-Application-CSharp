using System;

public class Util {
	public static string customStringInput(string inputMessage) {
		Console.WriteLine(inputMessage);
		string input = Console.ReadLine();

		return ErrorHandlers.stringCheck(input);
	}

	public static int customIntegerInput(string inputMessage) {
		Console.WriteLine(inputMessage);
		string input = Console.ReadLine();

		return ErrorHandlers.integerParseCheck(input);
	}

	public static void temporaryPauseApp() {
		Console.Write("\nPress any key to continue...");
		Console.ReadLine();
	}
}
