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
}
