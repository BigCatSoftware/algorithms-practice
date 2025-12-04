"""
03DEC2025
https://neetcode.io/problems/longest-substring-without-duplicates/question
"""

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        char_set = set()
        longest = 0

        left = 0
        for right, char in enumerate(s):
            while char in char_set:
                char_set.remove(s[left])
                left += 1
            char_set.add(char)
            longest = max(longest, right - left + 1)

        return longest
        
