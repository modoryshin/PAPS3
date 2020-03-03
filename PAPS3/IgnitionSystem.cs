using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    class IgnitionSystem:EnginePart
    {
        public IgnitionSystem(string name): base(name) { }
        public override void Display()
        {
            Console.WriteLine(this.name);
        }
    }
}
