"""
03DEC2025
https://neetcode.io/problems/buy-and-sell-crypto/question
"""

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        max_profit = 0
        buy = math.inf

        for num in prices:
            if num < buy:
                buy = num
            else:
                curr_profit = num - buy
                max_profit = max(max_profit, curr_profit)

        return max_profit
        
