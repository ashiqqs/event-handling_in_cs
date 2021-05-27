using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlingInCsharp
{
    public class SuperVisor
    {
        private Worker _worker;
        public Action<string,string> OnActiveSupervisorEvent;
        private string _name { get; set; }
        public SuperVisor(Worker worker, string superVisorName="Supervisor")
        {
            _worker = worker;
            _name = superVisorName;
            _worker.OnLoginEvent += OpenEyeEventHandler;
            _worker.OnLogoutEvent += OpenEyeEventHandler;
        }
        private void OpenEyeEventHandler(string workerName)
        {
            Console.WriteLine($"{_name} eyes are opened & seeing {workerName}");
            OnActiveSupervisorEvent?.Invoke(_name, workerName);
        }
    }
}
