using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if (numbers == null || numbers.Length < 2) return 0;

    // Array.Sort(numbers);

    // return numbers.Skip(1).Take(numbers.Length - 2).Sum();

    return numbers.Sum() - numbers.Min() - numbers.Max();
  }
}

class Program
{
  static void Main(string[] args)
  {
    int[] numbers = { 6, 2, 1, 8, 10 };
    int sum = Kata.Sum(numbers);
    Console.WriteLine("Sum of array excluding the highest and lowest: " + sum);
  }
}
