using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Unit6_IvanMartinovich
{
    class Customer
    {
        private int items;
        private DressingRoom dr;

        public Customer(DressingRoom dr, int items = 0)
        {
            this.dr = dr;
            this.items = items > 0 ? items : new Random().Next(1, 7);
        }

        public async Task EnterStore()
        {
            await dr.RequestRoom();

            //trying on clothes
            await Task.Delay(items * new Random().Next(1, 4) * 1000);

            dr.ReleaseRoom();
        }
    }
}
