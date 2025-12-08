/*
08DEC2025
https://leetcode.com/problems/valid-anagram/
*/

class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }

        Map<Character, Integer> charCount = new HashMap<>();
        for (char curr : s.toCharArray()) {
            charCount.put(curr, charCount.getOrDefault(curr, 0) + 1);
        }
        for (char curr : t.toCharArray()) {
            charCount.put(curr, charCount.getOrDefault(curr, 0) - 1);
        }

        for (Integer val : charCount.values()) {
            if (val != 0) {
                return false;
            }
        }

        return true;
        
    }
}
