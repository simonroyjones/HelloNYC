using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the current time in NYC");
    var time = Console.ReadLine();
    Console.WriteLine(time);
    int newTim = Convert.ToInt32(time);
    Console.WriteLine ("Hello New York City!");
  }
}