using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    class Engine: Component
    {
        private List<Component> components = new List<Component>();
        public Engine(string name) : base(name) { }
        public override void Display()
        {
            Console.WriteLine("Engine model:" + name);
            Console.WriteLine("Engine components:");
            foreach(Component comp in components)
            {
                comp.Display();
            }
        }
        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
