using System;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlingInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Manager manager = new Manager(worker);
            SuperVisor superVisor = new SuperVisor(worker);
            Boss boss = new Boss(manager, superVisor);

            worker.Login("Ashiq");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine();
            worker.Logout("Ashiq");
            
        }
    }
}
