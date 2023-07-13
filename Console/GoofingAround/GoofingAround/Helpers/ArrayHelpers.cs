using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoofingAround.Helpers;
public static class ArrayHelpers
{
    // Static method to find the min value of an array
    public static T Min<T>(this T[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("The array is empty.");
        }

        T min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (Comparer<T>.Default.Compare(array[i], min) < 0)
            {
                min = array[i];
            }
        }

        return min;
    }

    // Static method to find the max value of an array
    public static T Max<T>(this T[] array)
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("The array is empty.");
        }

        T max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (Comparer<T>.Default.Compare(array[i], max) > 0)
            {
                max = array[i];
            }
        }

        return max;
    }

    public static bool ContainsDuplicates<T>(T[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        if (array.Length <= 1)
        {
            return false; // No duplicates in an empty or single-element array
        }

        HashSet<T> encounteredElements = new HashSet<T>();

        foreach (T element in array)
        {
            if (element == null)
            {
                continue;
            }
            if (encounteredElements.Contains(element))
            {
                return true; // Found a duplicate
            }

            encounteredElements.Add(element);
        }

        return false; // No duplicates found
    }

    public static T[] RemoveDuplicates<T>(this T[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        if (array.Length <= 1)
        {
            return array; // No duplicates in an empty or single-element array
        }

        HashSet<T> encounteredElements = new HashSet<T>();
        List<T> uniqueElements = new List<T>();

        foreach (T element in array)
        {
            if (element == null)
            {
                continue;
            }

            if (!encounteredElements.Contains(element))
            {
                encounteredElements.Add(element);
                uniqueElements.Add(element);
            }
        }

        return uniqueElements.ToArray();
    }

    public static int[] RemoveDuplicates(this int[] array)
    {
        if (array == null)
        {
            throw new InvalidOperationException("array is null");
        }
        if (array.Length <= 1)
        {
            return array;
        }
        
        var temp = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (!temp.Contains(array[i]))
            {
                temp.Add(array[i]);
            }
        }

        return temp.ToArray();
    }

    public static int FindMax(this int[] array)
    {
        if(array == null)
        { 
            throw new InvalidOperationException("array is null");
        }
        if (array.Length == 0)
        {
            throw new InvalidOperationException("array is empty");
        }
        if (array.Length == 1)
        { 
            return array[0]; 
        }
        var max = array[0];
        foreach (var element in array)
        {
            if(element > max)
            {
                max = element;
            }                
        }
        return max;
    }
}
