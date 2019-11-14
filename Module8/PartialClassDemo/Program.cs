using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        // separate the static code from the code that will need maintenance
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(123);
            mc.PrintState();
        }
    }
}
