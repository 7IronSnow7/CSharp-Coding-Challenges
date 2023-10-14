using System;

public class MergeAlternately
{
	public static string Solution(string word1, string word2)
	{
        var mergedWord = new StringBuilder();
        var max = word1 + word2;

        for (var i = 0; i < max.Length; i++)
        {
            if (i < word1.Length)
            {
                mergedWord.Append(word1[i]);
            }
            if (i < word2.Length)
            {
                mergedWord.Append(word2[i]);
            }
        }
        return mergedWord.ToString();
    }
}
