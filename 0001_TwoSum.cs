/*
20JAN2026
1. TwoSum
https://leetcode.com/problems/two-sum/

Given an array of integers nums and an integer target, return indices
of the two numbers such that they add up to target. You may assume 
that each input would have exactly one solution, and you may not use
the same element twice. You can return the answer in any order.
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            int complement = target - curr;
            if (indices.ContainsKey(complement)) {
                return new int[] {indices[complement], i};
            }
            indices[curr] = i;
        }

        return new int[2];
    }
}
