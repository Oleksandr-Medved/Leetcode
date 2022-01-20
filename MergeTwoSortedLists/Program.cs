//You are given the heads of two sorted linked lists list1 and list2.

//Merge the two lists in a one sorted list. The list should be made by splicing together
//the nodes of the first two lists.

//Return the head of the merged linked list.

//Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
//Output:[1,1,2,3,4,4]
//Example 2:

//Input: list1 = [], list2 = []
//Output:[]
//Example 3:

//Input: list1 = [], list2 = [0]
//Output:[0]


var result = MergeTwoLists(new ListNode(1,new ListNode(2, new ListNode(4))),
    new ListNode(1, new ListNode(3, new ListNode(4))));

while (result?.next != null)
{
    Console.WriteLine(result.val);
}

static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    var tempNode = new ListNode();
    var resultNode = tempNode;   

    while (list1 != null && list2 != null)
    {
        if (list1.val < list2.val)
        {
            tempNode.next = list1;
            list1 = list1.next;
        }
        else
        {
            tempNode.next = list2;
            list2 = list2.next;
        }

        tempNode = tempNode.next;
    }

    if(list1 == null) tempNode.next = list2;
    if (list2 == null) tempNode.next = list1;
    return resultNode.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

