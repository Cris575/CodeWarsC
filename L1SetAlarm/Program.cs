using System;
using System.Linq; 

public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    // return employed && !vacation;
    if(employed & !vacation) return true;

    return false;
  }
}

class Program
{
  static void Main(string[] args)
  {
    bool count = Kata.SetAlarm(true, false);
    Console.WriteLine(count);
  }
}