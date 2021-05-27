using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlingInCsharp
{
    public class Boss
    {
        private Manager _manager;
        private SuperVisor _superVisor;
        public Boss(Manager manager, SuperVisor superVisor)
        {
            _manager = manager;
            _superVisor = superVisor;

            _manager.OnActiveManagerEvent += MonitorByBossEventHandler;
            _superVisor.OnActiveSupervisorEvent += MonitorByBossEventHandler;

        }

        private void MonitorByBossEventHandler(string empLevel1, string empLevel2)
        {
            Console.WriteLine($"Boss monitoring... {empLevel1} is active with {empLevel2}");
        }
    }
}
