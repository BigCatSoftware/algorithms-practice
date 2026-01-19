/*
18JAN2026
217. Contains Duplicate
https://leetcode.com/problems/contains-duplicate/

Given an integer array nums, return true if any value appears at 
least twice in the array, and return false if every element is distinct.
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums) {
            if (seen.Contains(num)) {
                return true;
            }
            seen.Add(num);
        }

        return false;
    }
}
