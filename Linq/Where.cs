using System.Collections.Generic;
using System.Linq;



public class MainClass1
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        List<int> evenNumbers = GetEvenNumbersLINQ(numbers);
    }

    static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();

        foreach (var item in numbers)
        {
            if (item % 2 == 0)
            {
                evenNumbers.Add(item);
            }
        }
        return evenNumbers;
    }

    static List<int> GetEvenNumbersLINQ(List<int> numbers)
    {
        List<int> evenNumbers = numbers.Where(item => item % 2 == 0).ToList();
        return evenNumbers;
    }    
}


