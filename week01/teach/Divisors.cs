public static class Divisors
{
  private static List<int> FindDivisors(int number)
  {
    List<int> results = [];
    for (var i = 1; i < number; i++)
    {
      if (number % i == 0)
      {
        results.Add(i);
      }
    }
    return results;
  }
  
  public static void Run()
  {
    List<int> list = FindDivisors(9);
    Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
    List<int> list1 = FindDivisors(7);
    Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
  }
}