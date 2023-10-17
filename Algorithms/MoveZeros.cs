using System;

public class MoveZeros
{
    public static void Solution(int[] nums)
    {
        if (nums.Length == 1) return;

        var nonZeroNumber = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = nums[nonZeroNumber];
                nums[nonZeroNumber] = temp;
                nonZeroNumber++;
            }
        }
    }
}
/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.
Example 1:

Input: nums = [0, 1, 0, 3, 12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
*/
