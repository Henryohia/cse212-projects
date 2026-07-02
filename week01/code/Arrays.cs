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

        // Create an array with the required length
        double[] result = new double[length];

        // Loop through each position in the array
        for (int i = 0; i < length; i++)
        {
            // Multiply the number by the current position + 1
            // Store the result in the array
            result[i] = number * (i + 1);
        }

        return []; // replace this return statement with your own
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

        // Create an array with the required length
        // Find the position where the list should be split
        int splitPoint = data.Count - amount;

        // Create a list containing the values from the split point to the end
        List<int> endPortion = data.GetRange(splitPoint, amount);

        // Create a list containing the values from the beginning to the split point
        List<int> beginningPortion = data.GetRange(0, splitPoint);

        // Clear the original list so it can be rebuilt
        data.Clear();

        // Add the end portion first
        data.AddRange(endPortion);

        // Add the beginning portion after it
        data.AddRange(beginningPortion);
    }
}
