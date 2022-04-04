using System;

namespace findmax
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a = { 1, 2, 3, 4, 5, -1, 33, 55, -5 };
      Console.WriteLine(FindMax(a));
      Console.WriteLine("Text Yayyyy")
    }
    public static int FindMax(int[] numbers)
    {
      if (numbers.Length == 0)
      {
        return -1;
      }

      int max = numbers[0];

      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] > max)
        {
          max = numbers[i];
        }
      }

      return max;
    }
  }
}
