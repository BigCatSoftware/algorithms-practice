/*
21JAN2026
49. Group Anagrams
https://leetcode.com/problems/group-anagrams/

Given an array of strings strs, group the anagrams
together. You can return the answer in any order.
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }
            groups[key].Add(str);
        }

        return new List<IList<string>>(groups.Values);
    }
}
