using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c = new Commando("aaa","jk");
            Console.WriteLine(c._codeName);
            c._codeName = "hhh";
            Console.WriteLine(c.SayName("GENERAL"));
        }
    }
}
