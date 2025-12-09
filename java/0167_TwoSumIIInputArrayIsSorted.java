/*
08DEC2025
https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
*/

class Solution {
    public int[] twoSum(int[] numbers, int target) {
        
        int left = 0;
        int right = numbers.length - 1;
        int currSum = 0;
        while (left < right) {
            currSum = numbers[left] + numbers[right];
            if (currSum < target) {
                left++;
            } else if (currSum > target) {
                right--;
            } else {
                return new int[] {left + 1, right + 1};
            }
        }

        return new int[]{};

    }
}
