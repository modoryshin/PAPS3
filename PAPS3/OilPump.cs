using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    class OilPump:EnginePart
    {
        public OilPump(string name):base(name) { }
        public override void Display()
        {
            Console.WriteLine(this.name);
        }
    }
}
