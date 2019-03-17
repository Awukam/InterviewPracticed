using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPracticed
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            String Names = "MUM\n DAD\n PAPA\n LION\n MOTHER\n FATHER\n";

            String ReverseResult = String.Join("   ", Names.Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(ReverseResult);
            Console.ReadLine();
            
        }
    }
}
