using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Unit6_IvanMartinovich
{
    class Scenario
    {
        private List<Customer> customersList;
        private DressingRoom dr;
        private Stopwatch sw = new Stopwatch();

        public double ElapsedTime => sw.Elapsed.TotalSeconds;

        public Scenario(int rooms, int customers)
        {
            dr = new DressingRoom(rooms);
            customersList = new List<Customer>();

            for (int i = 0; i < customers; i++)
            {
                customersList.Add(new Customer(dr));
            }
        }

        public async Task RunScenario()
        {
            sw.Start();

            var tasks = new List<Task>();
            foreach (var customer in customersList)
            {
                tasks.Add(customer.EnterStore());
            }

            await Task.WhenAll(tasks);
            sw.Stop();
        }
    }
}
