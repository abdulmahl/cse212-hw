public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    public static void Run()
    {
        var multiples = MultiplesOf(7, 5);
        Console.WriteLine("<double[]>{" + string.Join(", ", multiples) + "}");

        var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int amount = 3; // Rotate by 3 positions
        RotateListRight(data, amount);
        Console.WriteLine("Rotated List: {" + string.Join(", ", data) + "}");
    }
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Initialize an empty array of number multiple doubles.
        var multiples = new double[length];
        //Loop through and calculate each multiple.
        for (var i = 0; i < length; i++)
        {
            //Append each multiple numbe to the multiples array. 
            multiples[i] = number * (i + 1);
        }
        //Return new multiples array...
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Ensure amount is within the range of the list's length
        amount %= data.Count;

        // Get the last 'amount' elements
        List<int> rotatedPart = data.GetRange(data.Count - amount, amount);

        // Remove these elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // Insert the removed elements at the beginning of the list
        data.InsertRange(0, rotatedPart);
    }
}
