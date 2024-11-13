public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //make an array with length of <length>
        double [] result = new double[length];
        //make a loop that multiplies number by 1-length for each loop
        for (int i = 1; i <= length; i++){
            result[i-1] = number * i;
        }
        return result; // replace this return statement with your own
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
        //make a new result array with same length
        List<int> result = new List<int>();
        //make a loop that starts at the length - ammount shift right and counts up from there
        for (int i = 0; i < data.Count; i++){
            result.Add(data[(i + data.Count - amount) % data.Count]); //start at the end of <data> count in by <amount> and start at zero when out of bounds <data.Count> to count circularly
        }
        data.Clear();
        foreach (int item in result)
        {
            data.Add(item);
        }
    }
}
