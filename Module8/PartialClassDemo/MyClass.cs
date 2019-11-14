using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    // to be maintained
    partial class MyClass
    {
        public MyClass(int x)
        {
            this.myField = x;
        }

        public void PrintState()
        {
            Console.WriteLine("State: {0}", myField);
        }
    }
}
