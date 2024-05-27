namespace Workshop_C;
using System;
using System.Collections.Generic;

public class ArrayListOperation
{
    // 1. Encuentra el valor máximo en una lista
    public int GetMaxValue(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return 0;
        }

        int maximo = numbers[0];

        foreach (int num in numbers)
        {
            if (num > maximo)
            {
                maximo = num;
            }
        }

        return maximo;
    }
    // 2. Encuentra el valor mínimo en una lista
    public int GetMinValue(List<int> numbers)
    {
        int minValue = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        return minValue;
    }

    // 3. Calcula el promedio de una lista
    public double CalculateAverage(List<int> numbers)
    {
        double sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        double average = sum / numbers.Count;

        return average;
    }

    // 4. Encuentra un elemento en una lista y devuelve su índice
    public int FindElement(List<int> numbers, int element)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == element)
            {
                return i;
            }
        }

        return -1;
    }

    // 5. Cuenta las veces que un elemento aparece en una lista
    public int CountOccurrences(List<int> numbers, int element)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if (num == element)
            {
                count++;
            }
        }
        return count;
    }

    // 6. Invierte un array de enteros
    public int[] ReverseArray(int[] array)
    {

        int[] reversedArray = new int[array.Length];
        for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
        {
            reversedArray[j] = array[i];
        }

        return reversedArray;
    }

    // 7. Ordena un array de enteros en orden ascendente
    public int[] SortArray(int[] array)
    {

        Array.Sort(array);

        return array;
    }

    // 8. Devuelve una lista de elementos únicos
    public List<int> GetUniqueElements(List<int> numbers)
    {
        HashSet<int> uniqueSet = new HashSet<int>(numbers);
        List<int> uniqueElements = new List<int>(uniqueSet);
        uniqueElements.Sort();
        return uniqueElements;
    }

    // 9. Suma todos los elementos de una lista
    public int SumElements(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    // 10. Multiplica todos los elementos de una lista
    public long MultiplyElements(List<int> numbers)
    {
        long result = 1;
        foreach (int num in numbers)
        {
            result *= num;
        }
        return result;
    }

    // 11. Obtiene el segundo elemento más grande de una lista
    public int GetSecondLargest(List<int> numbers)
    {
        if (numbers.Count < 2)
        {
            return 0;
        }
        List<int> sortedNumbers = numbers.OrderByDescending(x => x).ToList();
        sortedNumbers = sortedNumbers.Distinct().ToList();
        if (sortedNumbers.Count >= 2)
        {
            return sortedNumbers[1];
        }
        else
        {
            return 0;
        }
    }

    // 12. Verifica si un array está ordenado
    public bool IsArraySorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }
    // 14. Rota un array por un número de posiciones
    public int[] RotateArray(int[] array, int positions)
    {
        int[] rotatedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            int newPosition = (i + positions) % array.Length;
            rotatedArray[newPosition] = array[i];
        }

        return rotatedArray;
    }

    // 15. Encuentra la mediana de una lista de enteros
    public double FindMedian(List<int> numbers)
    {
        numbers.Sort();

        int middleIndex = numbers.Count / 2;

        if (numbers.Count % 2 == 0)
        {
            return (double)(numbers[middleIndex - 1] + numbers[middleIndex]) / 2;
        }
        else
            return numbers[middleIndex];
    }

    // 16. Calcula la desviación estándar de una lista
    public double CalculateStandardDeviation(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double mean = sum / numbers.Count;
        double sumOfSquares = 0;
        foreach (int num in numbers)
        {
            sumOfSquares += Math.Pow(num - mean, 2);
        }
        double variance = sumOfSquares / numbers.Count;
        double standardDeviation = Math.Sqrt(variance);
        return standardDeviation;
    }

    // 17. Comprueba si un valor está en la lista
    public bool CheckForValue(List<int> numbers, int value)
    {
        foreach (int number in numbers)
            if (number == value)
            {
                return true;
            }

        return false;
    }

    // 18. Divide un array en dos subarrays en un índice específico
    public Tuple<int[], int[]> SplitArray(int[] array, int index)
    {
        if (index > array.Length)
        {
            return null;
        }
        int[] firstHalf = new int[index];
        int[] secondHalf = new int[array.Length - index];

        Array.Copy(array, 0, firstHalf, 0, index);
        Array.Copy(array, index, secondHalf, 0, array.Length - index);

        return Tuple.Create(firstHalf, secondHalf);
    }

    // 19. Encuentra el subarray más largo en un array
    public int[] FindLongestSubarray(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return null;
        }
        Array.Sort(array);

        int maxLength = 1;
        int currentLength = 1;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1] + 1)
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = i - maxLength + 1;
                    endIndex = i;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        if (maxLength == array.Length)
        {
            return array;
        }

        int[] longestSubarray = new int[maxLength];
        Array.Copy(array, startIndex, longestSubarray, 0, maxLength);

        return longestSubarray;
    }

    // 20. Encuentra la secuencia consecutiva más larga en una lista
    public List<int> FindLongestConsecutiveSubsequence(List<int> numbers)
    {
        HashSet<int> numberSet = new HashSet<int>(numbers);
        List<int> longestSubsequence = new List<int>();
        int maxLength = 0;

        foreach (int num in numbers)
        {
            if (!numberSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentLength = 1;

                while (numberSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLength++;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestSubsequence.Clear();

                    for (int i = num; i <= currentNum; i++)
                    {
                        longestSubsequence.Add(i);
                    }
                }
            }
        }

        return longestSubsequence;
    }

    public IEnumerable<int> RemoveDuplicates(List<int> numbers)
    {
        IEnumerable<int> uniqueNumbers = numbers.Distinct();
        return uniqueNumbers;
    }
}