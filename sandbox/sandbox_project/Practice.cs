using System;
using System.Collections.Generic;

public class Practice
{
  Queue<int> factorials = new();
  Queue<int> fibonaccii = new();

  public void Run()
  {
    var num = 5;
    var res = Factorial(num);
    var fibs = Fibonacci(7);
    Console.WriteLine($"Factorial of {num} is {res}");
    Console.WriteLine($"Fibonaccis: {fibs}");

    Console.WriteLine("Intermediate factorial values in the stack:");
    while (factorials.Count > 0)
    {
      Console.WriteLine(factorials.Dequeue());
    }

    Console.WriteLine("Intermediate fibonacci values in the stack:");
    while (fibonaccii.Count > 0)
    {
      Console.WriteLine(fibonaccii.Dequeue());
    }
  }

  public int Factorial(int num)
  {
    if (num <= 1)
    {
      factorials.Enqueue(1);
      return 1;
    }
    int result = num * Factorial(num - 1);
    factorials.Enqueue(result);
    return result;
  }

  public long Fibonacci(int n, Dictionary<int, long> remember = null)
  {
    // If this is the first time calling the function, then
    // we need to create the dictionary.
    if (remember == null)
      remember = new Dictionary<int, long>();

    // Base Case
    if (n <= 2)
      return 1;

    // Check if we have solved this one before
    if (remember.ContainsKey(n))
      return remember[n];

    // Otherwise solve with recursion
    var result = Fibonacci(n - 1, remember) + Fibonacci(n - 2, remember);

    // Remember result for potential later use
    remember[n] = result;
    return result;
  }
}