using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]

public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item and dequeue it.
    // Expected Result: The dequeued item should be the one added.
    public void TestPriorityQueue_EnqueueAndDequeue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result, "Dequeued item should match the enqueued item.");
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected Result: The item with the highest priority should be dequeued first.
    public void TestPriorityQueue_EnqueueMultipleAndDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("LowPriority", 1);
        priorityQueue.Enqueue("MediumPriority", 5);
        priorityQueue.Enqueue("HighPriority", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("HighPriority", result, "The item with the highest priority should be dequeued first.");
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    public void TestPriorityQueue_DequeueFromEmptyQueue_ThrowsException()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "Dequeueing from an empty queue should throw an exception.");
    }

    [TestMethod]
    // Scenario: Add items and check the queue string representation.
    // Expected Result: The queue's ToString should list all items in the order they were added.
    public void TestPriorityQueue_ToString()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 5);

        var result = priorityQueue.ToString();
        Assert.AreEqual("[Item1 (Pri:1), Item2 (Pri:5)]", result, "Queue's string representation should match the expected format.");
    }
}
