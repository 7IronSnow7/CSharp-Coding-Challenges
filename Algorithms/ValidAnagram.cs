using System;

public class ValidAnagram
{
	public static bool Solution(string s, string t)
	{
		// Anagram will have the same length
		if(s.Length != t.Length) return false;

		// Convert to character Array
		char[] charS = s.ToCharArray();
		char[] charT = t.ToCharArray();

		// Sort through the array ascending order
		Array.Sort(charS);
		Array.Sort(charT);

		// Convert back to string
		var sortedS = new string(charS);
		var sortedT = new string(charT);

		// Compare the values
		return sortedS == sortedT;
	}
}
