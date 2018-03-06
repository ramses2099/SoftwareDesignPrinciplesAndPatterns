using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            ILamp lamp = new Lamp();

            lamp.IsPlugged = true;

            lamp.IsSwitchOn = true;

            IFridge fridge = new Fridge();

            fridge.SetTemperature = 58d;

            fridge.IsPlugged = true;


            Console.ReadKey();

        }
    }
}
