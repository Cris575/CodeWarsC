using System;
using System.Linq; 

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Count(sheep => sheep);
  }
}

class Program
{
  static void Main(string[] args)
  {
    bool[] sheeps = { true, false, true, true, false, true, false, false, true };
    int count = Kata.CountSheeps(sheeps);
    Console.WriteLine($"Number of sheeps: {count}");
  }
}