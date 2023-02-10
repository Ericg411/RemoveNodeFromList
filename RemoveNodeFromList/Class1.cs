using System.Collections;

namespace RemoveNodeFromList;

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
public class Class1
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode result = new ListNode();
        Stack numHolder = new Stack();

        if (head.next == null)
        {
            return null;

        }

        while (head.next != null)
        {
            Console.WriteLine($"{head.val}");
            numHolder.Push(head.val);
            head = head.next;
        }
        numHolder.Push(head.val);


        int counter = numHolder.Count - 1;
        bool first = true;

        for (int i = 0; i <= counter; i++)
        {
            if (i + 1 != n)
            {
                if (first)
                {
                    result = new ListNode((int)numHolder.Pop(), null);
                    first = false;
                }
                else
                {
                    result = new ListNode((int)numHolder.Pop(), result);
                }

            }
            else
            {
                numHolder.Pop();
            }
        }
        return result;
    }
}
