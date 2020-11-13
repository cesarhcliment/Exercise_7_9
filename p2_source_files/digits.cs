/*
 * Counters of number of digits
 * 	digits1 is for 1 digit, 
 * 	digits2 is for 2 digits, 
 * 	digits3 is for 3 digits 
 * 	digits4 is for more than 3 digits
 * Cesar Higuero 1º DAW SEMI
 * Development Environments
 */
using System;

public class digits
{
	public static void Main()
	{
		string numText;
		int number;
		int digits1 = 0, digits2 = 0, digits3 = 0, digits4 = 0;

		do
		{
			Console.Write("Insert a number (end to finish): ");
			// read the number as string to check the word "end"
			numText = Console.ReadLine();

			if (numText != "end")
			{
				number = Convert.ToInt32(numText);
				
				if (number / 10 == 0)
					digits1++;
				else 
				if (number / 100 == 0)
					digits2++;
				else
				if (number / 1000 == 0)
					digits3++;
				else
					digits4++;
			}
		}
		while (numText != "end");

		Console.WriteLine("Size in digits -> one: {0} two: {1} three: {2} more: {3}", 
							digits1, digits2, digits3, digits4); 
	}
}
