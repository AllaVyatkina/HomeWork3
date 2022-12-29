using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("Введите пятизначное число");
      string n5 = Console.ReadLine();
      if (n5.Length == 5)
      {
        if ((n5[0] == n5[4]) && (n5[1] == n5[3]))
        {
          Console.WriteLine("Полиндром!");
        }
        else Console.WriteLine("Не полиндром"); 
      }
      else Console.WriteLine("Не соответсвует условию");
  }
}