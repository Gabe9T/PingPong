using System;
using System.Threading;

class Program
{
  static void Main()
  {
    Console.WriteLine("                         +++++++++++++++++");
    Console.WriteLine("                         Enter a Number:");
    Console.WriteLine("                         +++++++++++++++++");

    if (int.TryParse(Console.ReadLine(), out int userInput))
    {
      ConsoleColor[] colors = {
        ConsoleColor.DarkRed,
        ConsoleColor.Red,
        ConsoleColor.DarkMagenta,
        ConsoleColor.Magenta,
        ConsoleColor.DarkYellow,
        ConsoleColor.Yellow,
        ConsoleColor.DarkGreen,
        ConsoleColor.Green,
        ConsoleColor.DarkBlue,
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
          };

      for (int i = 1; i <= userInput; i++)
      {
        Thread.Sleep(100);
        ApplyColor(colors[i % colors.Length]);

        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("Ping Pong");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
    else
    {
      Console.WriteLine( "Enter a Number: ");
    }
  }
  static void ApplyColor(ConsoleColor colors)
  {
    Console.ForegroundColor = colors;
  }

}