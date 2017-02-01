using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureService
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Getting temperature: ");
            TemperatureService tempServ = new TemperatureService();
            tempServ.getTemperature();
            Console.WriteLine("The temprature is: {0}" , tempServ.getTemperature()); 

        }
    }
}
