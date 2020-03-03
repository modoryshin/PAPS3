using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public virtual void Display() { }
        public virtual void Add(Component comp) { }
        public virtual void Remove(Component comp) { }
    }
}
