namespace data_structures;

public class ComplexityArrays
{
    public static int CalculateOddSum(int[] array)
    {
        int sum = 0;
        int check;
        for (int i = 0; i < array.Length; i++)
        {
            check = array[i];
            if (check % 2 != 0) // Check if the number is odd
            {
                sum += check;
            }
        }
        return sum;
    }
    
    public static int FindMaximumTwo(int[] array)
    {
        int maxSum = array[0] + array[1];
        for (int i = 1; i < array.Length - 1; i++)
        {
            int currentSum = array[i] + array[i + 1];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;
    }
    
    public static bool ContainsNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                return true;
            }
        }
        return false;
    }
    
    
    public static int SumOfAllTriplets(int[] array)
    {
        int maxTripletSum = int.MinValue;
        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    int currentSum = array[i] + array[j] + array[k];
                    if (currentSum > maxTripletSum)
                    {
                        maxTripletSum = currentSum;
                    }
                }
            }
        }
        return maxTripletSum;
    }
    
    public static int FindMaxTripletSum(int[] array)
    {
        // Check if the array has less than 3 elements
        if (array.Length < 3)
        {
            throw new ArgumentException("Array must have at least three elements.");
        }

        // Initialize three variables to store the three largest numbers
        int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;

        // Traverse the array to find the three largest numbers
        foreach (int num in array)
        {
            if (num > max1)
            {
                // Shift the values down
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                // Shift the values down
                max3 = max2;
                max2 = num;
            }
            else if (num > max3)
            {
                max3 = num;
            }
        }

        // Calculate and return the maximum triplet sum
        return max1 + max2 + max3;
    }


    // o(n)
    // public static int[] FindLastClosePairWithProduct(int[] array, int product)
    // {
    //     // idea: move from the end to the begining and find the first.
    //     for (int i = 0; i < array.Length - 1; i++) // 
    //     {
    //         
    //     }
    // }
    
    // o(n^2)
    // public static int[] FindLastNotClosePairWithProduct(int[] array, int product)
    // {
    //     for ()
    // }
    
    
    
    
    
    
    
}