/*
20JAN2026
242. Valid Anagram
https://leetcode.com/problems/valid-anagram/

Given two strings s and t, return true if t is an of s, and false otherwise.
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        int[] chars = new int[26];

        foreach (char c in s) {
            chars[c - 'a']++;
        }

        foreach (char c in t) {
            chars[c - 'a']--;
        }

        foreach (int i in chars) {
            if (i != 0) {
                return false;
            }
        }

        return true;
    }
}
