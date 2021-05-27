using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlingInCsharp
{
    public class Manager
    {
        private Worker _worker;
        public event Action<string, string> OnActiveManagerEvent;
        private string _name { get; set; }
        public Manager(Worker worker, string name="Manager")
        {
            _worker = worker;
            _name = name;

            _worker.OnLoginEvent += OpenEyeEventHandler;
            _worker.OnLogoutEvent += OpenEyeEventHandler;
        }

        private void OpenEyeEventHandler(string workerName)
        {
            Console.WriteLine($"{_name} eyes are opened & seeing {workerName}");
            OnActiveManagerEvent?.Invoke(_name, workerName);
        }
    }
}
