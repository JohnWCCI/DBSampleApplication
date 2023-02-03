// See https://aka.ms/new-console-template for more information
using System.Linq;
using DBSampleConsole.Context;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

try
{
    MyDBContext context = new();
   

    var l = (from a in context.Students
                               select a).ToList();

      foreach(var s in l.ToList())
    {
        Console.WriteLine(s.LastName);
    }

}
catch(Exception ex)
{ 
    Console.WriteLine(ex);
}

Console.WriteLine();
