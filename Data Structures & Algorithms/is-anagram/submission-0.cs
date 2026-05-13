public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char item in s)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict[item] = 1;
            }
        }

         foreach (char item in t)
        {
            if (!dict.ContainsKey(item) || dict[item] == 0)
            {
                return false;
            }

            dict[item]--;
        }

        return true;
    }
}
