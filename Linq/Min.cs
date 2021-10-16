using System;
using System.Collections.Generic;
using System.Linq;



public class MainClass3
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(MinLINQ(numbers));
    }

    static int Min(List<int> numbers)
    {
        int min = numbers[0];

        foreach (var item in numbers)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    static int MinLINQ(List<int> numbers)
    {
        return numbers.Min();
    }
}