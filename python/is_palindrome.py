"""
02DEC2025
https://neetcode.io/problems/is-palindrome/question
"""

class Solution:
    def isPalindrome(self, s: str) -> bool:
        if len(s) == 0:
            return False
        
        string = "".join(c.lower() for c in s if c.isalnum())

        left, right = 0, len(string) - 1
        while left < right:
            if string[left] == string[right]:
                left += 1
                right -= 1
            else:
                return False

        return True
        
