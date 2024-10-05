using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new();
        dictionary.Add("Book", 23);
        dictionary.Add("Bag", 13);
        dictionary.Add("Bike", 24);
        dictionary.Add("Glasses", 53);
        dictionary.Add("Stool", 43);

        Console.WriteLine("Dictionary items: ");
        foreach (var item in dictionary)
        {
            Console.WriteLine(item);
        }

        Hashtable htable = new();
        htable.Add(2, "Bread");
        htable.Add(44, "Eggs");
        htable.Add(66, "Milk");
        htable.Add(12, "Butter");
        htable.Add(33, "Oil");

        Console.WriteLine("Hashtable contents: ");
        foreach (var content in htable)
        {
            Console.WriteLine(content);
        }

        string[] arr = { "Pen", "Book", "Tape", "Tape" };

        var hset = new HashSet<string>(arr);
        hset.Add("Greens");
        hset.Add("Beans");
        hset.Add("Basil");

        Console.WriteLine("Set output: ");
        foreach (var set in hset)
        {
            Console.WriteLine(set);
        }
    }
}