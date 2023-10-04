using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IT481_Unit6_IvanMartinovich
{
    class DressingRoom
    {
        private SemaphoreSlim sp;
        
        public DressingRoom(int rooms = 3)
        {
            sp = new SemaphoreSlim(rooms, rooms);
        }

        public async Task RequestRoom()
        {
            await sp.WaitAsync();
        }

        public void ReleaseRoom()
        {
            sp.Release();
        }
    }
}
