using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
 class Program
 { 
  static void Main(string[] args) 
  {
   Console.Title = "First C# Console Application";
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Hello C#!");

   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("Hello C#!");

   Console.WriteLine("First line");
   Console.WriteLine("Second line");
   Console.WriteLine("Third line");

   Console.Write("First word");
   Console.Write("Second word");
   Console.Write("Third word");
   Console.WriteLine();

/* Escape sequences: 
 *  \n - new line
 *  \t - tabulation
 *  \" - "
 *  \' - '
 *  \\ - \
 */

   Console.WriteLine("Hello, my name is \"Vlad!\"");
// snippet: cw + TAB
   Console.WriteLine("One\tTwo\tThree\n\\____________________\\");

// ---------------- read data from console
   Console.Write("Enter login: ");
   string login = Console.ReadLine();
   Console.WriteLine($"Your login is {login}!");

   Console.ReadKey(); // press any key
  }
 }
}


