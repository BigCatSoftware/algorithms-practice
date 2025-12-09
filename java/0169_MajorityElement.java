/*
08DEC2025
https://leetcode.com/problems/majority-element/
*/

class Solution {
    public int majorityElement(int[] nums) {
        Map<Integer, Integer> numCounter = new HashMap<>();
        
        for (int num : nums) {
            numCounter.put(num, numCounter.getOrDefault(num, 0) + 1);
            if (numCounter.get(num) > (nums.length / 2)) {
                return num;
            }
        }

        return -1;
    }
}
