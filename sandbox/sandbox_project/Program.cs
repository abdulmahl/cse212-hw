using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> LLlist = new(); // Create new node.
        LLlist.AddLast("A"); // Current node...
        LLlist.AddLast("B");
        LLlist.AddLast("C");
        LLlist.AddLast("D");

        //Insert X at the head...
        var currentHeadNodeWhichIsA = LLlist.Find("A");

        if (currentHeadNodeWhichIsA != null)
        {
            LLlist.AddBefore(currentHeadNodeWhichIsA, "X");
        }

        //Insert Y between C & B...
        LinkedListNode<string> nodeB = LLlist.Find("B");

        //check if B exists...
        if (nodeB != null)
        {
            LLlist.AddAfter(nodeB, "Y");
        }

        LLlist.RemoveLast();
        LLlist.Remove(nodeB);


        // LLlist.RemoveFirst();

        // LinkedListNode<int> node45 = LLlist.Find(45);
        // LinkedListNode<int> current = LLlist.Find(66);

        int i = 0;
        foreach (var item in LLlist)
        {
            Console.WriteLine($"{i + 1}. {item}");
            i++;
        }

        // Console.WriteLine("Current Value: {0}", current.Value);
        // Console.WriteLine($"Value After Current: {current.Next.Value}");
        // Console.WriteLine($"Value Before Current: {current.Previous.Value}");
    }
}