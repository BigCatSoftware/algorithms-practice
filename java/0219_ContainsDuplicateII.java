/*
08DEC2025
https://leetcode.com/problems/contains-duplicate-ii/
*/

class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        Map<Integer, Integer> indices = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            int currNum = nums[i];
            if (indices.containsKey(currNum)) {
                if (Math.abs(indices.get(currNum) - i) <= k) {
                    return true;
                }
                indices.put(currNum, i);
            } else {
                indices.put(currNum, i);
            }
        }

        return false;
    }
}
