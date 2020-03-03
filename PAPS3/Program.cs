using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание нового объекта двигателя
            Component engineObject = new Engine("Новый двигатель");
            //Создание компонент "Система зажигания" и "Топливный насос"
            Component ignitionsys1 = new IgnitionSystem("Система зажигания 1");
            Component oilpump1 = new OilPump("Топливный насос 1");
            Component ignitionsys2 = new IgnitionSystem("Система зажигания 2");
            Component oilpump2 = new OilPump("Топливный насос 2");
            //Добавление компонент к двигателю
            engineObject.Add(ignitionsys1); engineObject.Add(ignitionsys2);
            engineObject.Add(oilpump1); engineObject.Add(oilpump2);
            engineObject.Display();
            //Удаление компонент
            engineObject.Remove(ignitionsys2); engineObject.Remove(oilpump1);
            engineObject.Display();
            Console.ReadKey();
        }
    }
}
