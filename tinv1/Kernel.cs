using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace tinv1
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("welcome to tin 1.0 dev build");
        }

        protected override void Run()
        {
            
        }
    }
}
