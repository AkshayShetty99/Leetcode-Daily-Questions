public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int count1 = 0;
        for(int i = 0; i < s.Length; i++)
        {
            count1 += s[i] - '0';   //ASCII character value of 0-9 is 48-57
        }
        StringBuilder result = new StringBuilder();
        for(int i = 0; i < count1 -1; i++){
            result.Append("1");
        }
        for(int i = 0; i < s.Length-count1; i++){
            result.Append("0");
        }
        result.Append("1");
        return result.ToString();
    }
}
