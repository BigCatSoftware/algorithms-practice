"""
03DEC2025
https://neetcode.io/problems/longest-repeating-substring-with-replacement/question
"""

class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        char_count = defaultdict(int)
        left = 0
        max_freq = 0
        longest = 0

        for right in range(len(s)):
            char = s[right]
            char_count[char] += 1
            max_freq = max(char_count.values())

            while (right - left + 1) - max_freq > k:
                char_count[s[left]] -= 1
                left += 1

            longest = max(longest, right - left + 1)

        return longest
