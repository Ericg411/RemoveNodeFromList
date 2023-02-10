namespace RemoveNodeFromList.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));

        ListNode answer = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5, null))));

        ListNode result = _test.RemoveNthFromEnd(head, 2);

        int answerValue = 0;
        int resultValue = 0;

        while (answer.next != null)
        {
            answerValue += (int)answer.val;
            answer = answer.next;
        }

        while (result.next != null)
        {
            resultValue += (int)result.val;
            result = result.next;
        }

        Assert.AreEqual(answerValue, resultValue);
    }

    [TestMethod]
    public void TestMethod2()
    {
        ListNode head = new ListNode(1, new ListNode(2, null));

        ListNode answer = new ListNode(1, null);

        ListNode result = _test.RemoveNthFromEnd(head, 1);

        int answerValue = 0;
        int resultValue = 0;

        while (answer.next != null)
        {
            answerValue += (int)answer.val;
            answer = answer.next;
        }

        while (result.next != null)
        {
            resultValue += (int)result.val;
            result = result.next;
        }

        Assert.AreEqual(answerValue, resultValue);
    }
}