using System;
using System.Collections.Generic;
using System.Linq;



public class MainClass4
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(CountEven(numbers));
    }

    static int CountEven(List<int> numbers)
    {
        int count = 0;

        foreach (var item in numbers)
        {
            if (item % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    static int CountEvenLINQ(List<int> numbers)
    {
        return numbers.Count(item => item % 2 == 0);
    }
}
