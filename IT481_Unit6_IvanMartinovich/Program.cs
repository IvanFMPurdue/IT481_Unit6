using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Unit6_IvanMartinovich
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var scenario1 = new Scenario(3, 10);
            await scenario1.RunScenario();
            Console.WriteLine($"Scenario 1: 3 rooms and 10 customers\nElapsed time: {scenario1.ElapsedTime} seconds\n\n");

            var scenario2 = new Scenario(5, 5);
            await scenario2.RunScenario();
            Console.WriteLine($"Scenario 2: 5 rooms and 5 customers\nElapsed time: {scenario2.ElapsedTime} seconds\n\n");

            var scenario3 = new Scenario(7, 1);
            await scenario3.RunScenario();
            Console.WriteLine($"Scenario 3: 7 rooms and 1 customers\nElapsed time: {scenario3.ElapsedTime} seconds\n\n");

            Console.ReadLine();
        }
    }
}
