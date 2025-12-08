/*
08DEC2025
https://leetcode.com/problems/two-sum/
*/

class Solution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> indices = new HashMap<>();

        int i = 0;
        for (int num : nums) {
            int complement = target - num;
            if (indices.containsKey(complement)) {
                return new int[] {indices.get(complement), i};
            }
            indices.put(num, i);
            i++;
        }

        return new int[]{};
        
    }
}
