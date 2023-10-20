using System;
using System.Collections.Generic;

public class PigLatin
{
	public static string Soltuion(string text)
	{
		var pigLatin = new StringBuilder();
		var pigLatinAlphabet = "ay";
		string[] words = text.Split(' ');

		for(var i = 0; i < words.Length; i++)
		{
			var firstLetter = words[i][0];
			words[i] = words[i].Substring(1) + firstLetter;

			if(i > 0)
			{
				pigLatin.Append(" ");
			}
			pigLatin.Append(words[i]);
			pigLatin.Append(pigLatinAlphabet);
		}
		return pigLatin.ToString().Trim();
		
	}
}
/*You have two friends who are speaking Pig Latin to each other! Pig Latin is the same words in the same order except that you take
the first letter of each word and put it on the end, then you add 'ay' to the end of that. ("road" = "oadray") 

Task
Your task is to take a sentence in English and turn it into the same sentence in Pig Latin! 

Input Format 
A string of the sentence in English that you need to translate into Pig Latin. (no punctuation or capitalization)

Output Format 
A string of the same sentence in Pig Latin.

Sample Input 
"nevermind youve got them"

Sample Output 
"evermindnay ouveyay otgay hemtay"*/