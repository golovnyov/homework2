using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customDataStructure = new CustomDataStructure(x => { return x; });

            for (int i = 0; i < 1e6; i++)
            {
                customDataStructure[i] = i;
            }

            Console.ReadLine();
        }
    }
}
