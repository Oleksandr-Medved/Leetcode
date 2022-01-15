//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".



//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.

var result = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

Console.WriteLine(result);

static string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return String.Empty;

    var prefix = strs[0];

    for (int i = 1; i < strs.Length; i++)
    {
        while(strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (prefix.Length == 0) return String.Empty;
        }
    }

    return prefix;
}