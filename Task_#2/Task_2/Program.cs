﻿using System.Text;

// Summation 1 to N using Looping

Console.Write("Enter a number: ");

var MaxNumberFormUser = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(MaxNumberFormUser) && int.TryParse(MaxNumberFormUser, out int MaxNamber))
{
	var sum = 0;
	for (var i = 1; i <= MaxNamber; i++)
	{
		sum += i;
	}

	Console.WriteLine($"[Looping] The sum from 1 to {MaxNamber} is: {sum}");

	var sumFromFormula = MaxNamber * (MaxNamber + 1) / 2;
	Console.WriteLine($"[Formula] The sum from 1 to {MaxNamber} is: {sumFromFormula}");
}
else
{
	Console.WriteLine("Invalid input! Please enter a valid integer number.");
}

// Print numbers from 1 to n using StringBuilder (no without last comma)

Console.Write("Enter a number: ");
var input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out var n))
{
	var sb = new StringBuilder();

	for (var i = 1; i <= n; i++)
	{
		sb.Append(i);
		if (i < n)
		{
			sb.Append(", ");
		}
	}

	Console.WriteLine($"Numbers from 1 to {n}:");
	Console.WriteLine(sb.ToString());
}
else
{
	Console.WriteLine("Invalid input! Please enter a valid integer.");
}

/*  (String (Immutable))

    - In C#, string is immutable.
    - Every time you do: str += "something", a new string is created in memory.
    - Example:
        string str = "";
        for (int i = 0; i < 1000; i++)
            str += i.ToString();

    - This creates a new string 1000 times ⇒ very slow and memory-heavy.
    - Time complexity: O(n²)
*/

/*  (StringBuilder (Mutable))

    - StringBuilder is mutable.
    - Internally, it uses a resizable character array (char[] buffer).
    - When you call .Append(), it adds to the buffer instead of creating a new string.
    - If the buffer fills up, it automatically resizes (usually by doubling its size).
    - Time complexity: O(n) amortized.

    - Example:
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 1000; i++)
            sb.Append(i);

    - Only one buffer resize may happen, making it highly efficient.
*/


