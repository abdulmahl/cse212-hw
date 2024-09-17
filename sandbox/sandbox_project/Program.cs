using System;

public class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        numbers.Add(55);
        numbers.Add(58);
        numbers.Add(45);
        numbers.Remove(1);
        numbers.Insert(1, 88);

        int count = numbers.Count;
        foreach (int number in numbers)
        {
            string price = string.Format("{0:C}", number);
            Console.WriteLine($"Dynamic Array Value: {price}");
        }

        Console.WriteLine($"Dynamic Array Count is: {count}");
    }
}