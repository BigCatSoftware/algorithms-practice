"""
04DEC2025
https://neetcode.io/problems/validate-parentheses/question
"""

class Solution:
    def isValid(self, s: str) -> bool:
        groups = {
            ']': '[',
            '}': '{',
            ')': '('
        }

        stack = []
        for char in s:
            if char in groups.values():
                stack.append(char)
            elif char in groups:
                if stack and stack[-1] == groups[char]:
                    stack.pop()
                else:
                    return False

        return not stack
        
