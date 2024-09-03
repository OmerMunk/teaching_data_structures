namespace data_structures;

public class ComplexityArrays
{
    public static int CalculateOddSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0) // Check if the number is odd
            {
                sum += array[i];
            }
        }
        return sum;
    }
}