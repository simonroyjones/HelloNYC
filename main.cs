using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter the current time in NYC (hh:mm): ");
    var time = Console.ReadLine();
    int colonPos = time.IndexOf(":");
    int newTim = Convert.ToInt32(time.Substring(0,colonPos));
    Console.WriteLine(newTim);
    if {Convert.ToInt32(newTim) < 12}
      Console.WriteLine ("Good Morning New York City!");
    else
      Console.WriteLine("Good afternoon, New York City!")
    end
  }
}