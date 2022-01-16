//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.


//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false

var result = IsValid("(){})");

Console.WriteLine(result);

static bool IsValid(string s)
{
    if (s.Length <= 1) return false;

    var dict = new Dictionary<char, char>()
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}',
    };

    var stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (dict.ContainsKey(s[i]))
            stack.Push(dict[s[i]]);
        else if (stack.Count == 0 || stack.Pop() != s[i]) return false;
    }
    return stack.Count == 0;
}
