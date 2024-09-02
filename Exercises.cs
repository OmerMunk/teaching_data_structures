namespace data_structures;

public class Exercises
{
    public static int[] Ex0CopyArray(int[] array)
    {
        int[] copy = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copy[i] = array[i];
        }
        return copy;
    }
    
    // [1, 2, 3]
    public static int[] Ex1ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length]; // 1
        //       1            4            3
        for (int i = 0; i < array.Length; i++)
        {
            // 3
            reversed[i] = array[array.Length - 1 - i]; // 1
        }
        return reversed; // 1
        // n = 3:  1 + 1 + 4 +    n +    n    + 1 = 13
        // n = 4:  1 + 1 + 5 +    n +    n    + 1 = 16
        // n = 5:  1 + 1 + 6 +    n +    n    + 1 = 19
        
        // O(n)
        
        // n!
    }
}