/*
09DEC2025
https://leetcode.com/problems/group-anagrams/
*/

class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, List<String>> groups = new HashMap<>();

        for (String str : strs) {
            int[] charCount = new int[26];
            for (char c : str.toCharArray()) {
                charCount[c - 'a']++;
            }
            String key = Arrays.toString(charCount);
            groups.computeIfAbsent(key, k -> new ArrayList()).add(str);
        }

        return new ArrayList<>(groups.values());

    }
}
