// See https://aka.ms/new-console-template for more information
using System.Linq;
using DBSampleConsole;

try
{
    MyDBContext context = new MyDBContext();
 }
catch(Exception ex)
{ 
    Console.WriteLine(ex);
}

Console.WriteLine();
