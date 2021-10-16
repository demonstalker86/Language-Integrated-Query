using System;
using System.Collections.Generic;
using System.Linq;



public class MainClass2
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(SumLINQ(numbers));
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;

        foreach (var item in numbers)
        {
            if (item % 2 == 0)
            {
                sum += item;
            }
        }
        return sum;
    }

    static int SumLINQ(List<int> numbers)
    {
        return numbers.Sum();
    }
}
