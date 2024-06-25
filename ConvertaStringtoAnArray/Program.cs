using System;
using System.Linq; 

public class Kata {
  public static string[] StringToArray(string str)
    {
      return str.Split(" ");
    }
}

class Program
{
  static void Main(string[] args)
  {
    string[] count = Kata.StringToArray("Robin Singh");
    Console.WriteLine(count[1]);
  }
}