/*
 * Calculate the average of some numbers
 * Cesar Higuero 1º DAW SEMI
 * Development Environments
*/

using System;

public class Average
{
	public static void Main()
	{
		string markText;
		double mark;
		int counter = 0;
		double sum = 0;
		double average;

		do 
		{
			Console.Write("Insert a mark (end to finish): ");
			markText = Console.ReadLine();	// we read the mark as string to check the word "end"	 
			
			if (markText != "end")
			{
				mark = Convert.ToDouble(markText);
				counter++;   
				sum += mark; 
			}
			
		} while(markText != "end");
		
		if (counter > 0)
		{
			average = sum / counter;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
