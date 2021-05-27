using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlingInCsharp
{
    public class Worker
    {
        public event Action<string> OnLoginEvent;
        public event Action<string> OnLogoutEvent;

        public void Login(string name)
        {
            Console.WriteLine($"{name} Login");
            OnLoginEvent?.Invoke(name);
        }
        public void Logout(string name)
        {
            Console.WriteLine($"{name} Logout");
            OnLogoutEvent?.Invoke(name);
        }
    }
}
