using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAFESAEnrolmentSystem.Classes
{
    public class Utility
    {
        /// <summary>
        /// Searches for a target element in an array using linear search.
        /// 
        /// Pseudocode:
        /// i = 0
        /// found = false
        /// WHILE not found AND i < length of array
        ///     IF array[i] equals target
        ///         found = true
        ///     ELSE
        ///         i = i + 1
        ///     END IF
        /// END WHILE
        /// IF i < length of array
        ///     RETURN i
        /// ELSE
        ///     RETURN -1
        /// END IF
        /// </summary>
        /// 
        /// <typeparam name="T">The type of elements in the array (must implement IComparable&lt;T&gt;)</typeparam>
        /// <param name="array">The array to search through</param>
        /// <param name="target">The value to find</param>
        /// <returns>The index of the target if found; otherwise, -1</returns>
        public static int LinearSeachArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;

            while (!found && i < array.Length)
            {
                if (array[i].CompareTo(target) == 0)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            if (i < array.Length)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Searches for a target element in a sorted array using binary search.
        /// 
        /// Pseudocode:
        /// min = 0
        /// max = length of array - 1
        /// WHILE min <= max
        ///     mid = (min + max) / 2
        ///     IF array[mid] equals target
        ///         RETURN mid
        ///     ELSE IF array[mid] < target
        ///         min = mid + 1
        ///     ELSE
        ///         max = mid - 1
        ///     END IF
        /// END WHILE
        /// RETURN -1  // target not found
        /// </summary>
        /// 
        /// <typeparam name="T">The type of elements in the array (must implement IComparable&lt;T&gt;)</typeparam>
        /// <param name="array">The sorted array to search through</param>
        /// <param name="target">The value to find</param>
        /// <returns> The index of the target if found; otherwise, -1 </returns>

        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (array[mid].CompareTo(target) == 0)
                {
                    return mid;
                }
                else if (array[mid].CompareTo(target) < 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }

        // SORTING

        /// <summary>
        /// Sorts an array in ascending order using the selection sort algorithm.
        /// 
        /// Pseudocode:
        /// FOR i = 0 TO end of array
        ///     minIndex = i
        ///     FOR j = i + 1 TO end of array
        ///         IF array[j] < array[minIndex]
        ///             minIndex = j
        ///         END IF
        ///     END FOR
        ///     temp = array[minIndex]
        ///     array[minIndex] = array[i]
        ///     array[i] = temp
        /// END FOR
        /// </summary>
        /// 
        /// <typeparam name="T">The type of elements in the array (must implement IComparable&lt;T&gt;)</typeparam>
        /// <param name="array">The array to sort</param>
        public static void SelectionSortAscending<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            int minIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // Swap
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        /// <summary>
        /// Sorts an array in descending order using the selection sort algorithm.
        /// 
        /// Pseudocode:
        /// FOR i = 0 TO end of array
        ///     maxIndex = i
        ///     FOR j = i + 1 TO end of array
        ///         IF array[j] > array[maxIndex]
        ///             maxIndex = j
        ///         END IF
        ///     END FOR
        ///     temp = array[maxIndex]
        ///     array[maxIndex] = array[i]
        ///     array[i] = temp
        /// END FOR
        /// </summary>
        /// 
        /// <typeparam name="T">The type of elements in the array (must implement IComparable&lt;T&gt;)</typeparam>
        /// <param name="array">The array to sort</param>
        public static void SelectionSortDescending<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            int maxIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                maxIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }

                // Swap
                temp = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
