using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sys = Cosmos.System;

namespace tinv1.command
{
    public class command
    {
        public readonly string name;
        public command(string name) 
        {
            this.name = name;
        }
        public virtual string Execute(string[] args)
        {
            return"";
        }
    }
}
