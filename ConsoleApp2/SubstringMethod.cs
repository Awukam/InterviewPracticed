using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SubstringMethod
    {
        static void Main(string[] args)
        {
            String Name = "/*(one)*/";
            //The SUBSTRING METHOD:-It is used to retrieve a substring from the current instance of the string.
            Console.WriteLine(Name.Substring(8,1));
            Console.ReadLine();
        }
    }
}
