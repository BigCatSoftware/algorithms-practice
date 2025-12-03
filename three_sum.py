"""
02DEC2025
https://neetcode.io/problems/three-integer-sum/question
"""

class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        result = []

        for i, num in enumerate(nums):
            if i > 0 and num == nums[i - 1]:
                continue
            if num > 0:
                break

            j, k = i + 1, len(nums) - 1
            while j < k:
                curr_list = [num, nums[j], nums[k]]
                curr_sum = sum(curr_list)
                if curr_sum < 0:
                    j += 1
                elif curr_sum > 0:
                    k -= 1
                else:
                    result.append(curr_list)
                    j += 1
                    k -= 1
                    while nums[j] == nums[j - 1] and j < k:
                        j += 1
                    while nums[k] == nums[k + 1] and j < k:
                        k -= 1
            
        return result
        
