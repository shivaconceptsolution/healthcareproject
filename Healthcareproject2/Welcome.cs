using System;
class Welcome
{
     static int a,b,c;
     static void displayWelcome()
     {
          Console.WriteLine("Welcome in C#");

     }
     static void Addition()
     {
          Console.WriteLine("Enter First Number");
          a=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter First Number");
          b=Convert.ToInt32(Console.ReadLine());
          c=a+b;
          Console.WriteLine("result of {0}+{1}={2}",a,b,c);
          
     }
     public static void Main()
     {
         
        Welcome.displayWelcome();
        Welcome.Addition();
         
     }

}