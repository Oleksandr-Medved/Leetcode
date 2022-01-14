
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output:[0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

var result = TwoSum(new int[] { 3, 3 }, 6);


foreach (int i in result)
{
    Console.WriteLine(i);
}

static int[] TwoSum(int[] nums, int target)
{
    var list = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int item = nums[i];

        if (list.Contains(target - item))
            return new int[] { list.IndexOf(target - item), i };

        else list.Add(item);
    }

    return new int[] { 0, 0 };
}