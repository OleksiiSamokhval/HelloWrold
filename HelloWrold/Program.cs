using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWrold
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string temp;
            Console.WriteLine("Hello World");
            Console.WriteLine("Do you want somethig to add?");
            Console.WriteLine("make input and press ENTER");
            temp = Console.ReadLine();
            Console.WriteLine("your input was " + temp);
        }
    }
}
