/*
25JAN2026
238. Product of Array Except Self
https://leetcode.com/problems/product-of-array-except-self/

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.
*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            output[i] = 1;
        }

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++) {
            output[i] *= prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i = nums.Length - 1; i > -1; i--) {
            output[i] *= postfix;
            postfix *= nums[i];
        }

        return output;
    }
}
