/*
22JAN2026
https://leetcode.com/problems/top-k-frequent-elements/

347. Top K Frequent Elements
Given an integer array nums and an integer k, return 
the k most frequent elements. You may return the answer 
in any order.
*/

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counter = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!counter.ContainsKey(num)) {
                counter[num] = 0;
            }
            counter[num]++;
        }

        var pq = new PriorityQueue<int, int>();
        foreach (var pair in counter) {
            pq.Enqueue(pair.Key, pair.Value);
            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        int[] res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}
