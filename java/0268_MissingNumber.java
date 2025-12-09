/*
09DEC2025
https://leetcode.com/problems/missing-number/
*/

class Solution {
    public int missingNumber(int[] nums) {
        int rangeEnding = nums.length;

        Set<Integer> numSet = new HashSet<>();
        for (int num : nums) {
            numSet.add(num);
        }

        for (int i = 0; i <= rangeEnding; i++) {
            if (!numSet.contains(i)) {
                return i;
            }
        }

        return -1;
    }
    // alternate math approach Time O(n), Space O(1)
  /*
    public int missingNumber(int[] nums) {
        // summation max index
        int n = nums.length;
        
        // Gauss Summation
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        for (int num : nums) {
            actualSum += num;
        }
        
        return expectedSum - actualSum;
    }
  */
}
