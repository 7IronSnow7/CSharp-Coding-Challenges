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
/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
*/
