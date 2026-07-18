using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities.
    // Expected Result: The item with the highest priority is removed first.
    // Defect(s) Found: Dequeue did not remove the highest-priority item correctly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 3);

        Assert.AreEqual("Sue", priorityQueue.Dequeue());

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The first item added with the highest priority is removed first (FIFO).
    // Defect(s) Found: Queue removed the wrong item when priorities were equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("Tim", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to remove from an empty queue.
    // Expected Result: InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Remove several items.
    // Expected Result: Items are removed from highest priority to lowest priority.
    // Defect(s) Found: None.
    public void TestPriorityQueue_MultipleRemovals()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Jane", 2);

        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Jane", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }
}