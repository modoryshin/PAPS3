using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    abstract class EnginePart:Component
    {
        public EnginePart(string name):base(name)
        { }
        public override void Display() { }
    }
}
