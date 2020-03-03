using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        string name;
        string managerChoice;


        public void CreateMarketingFirmWithManager()
        {
            Console.WriteLine("Enter marketing firm name:  ");
            name = Console.ReadLine();
            Console.WriteLine("Tye preferred manager, stack or queue, then hit enter:  ");
            managerChoice = Console.ReadLine();
            ISweepstakesManager manager = null;

            switch (managerChoice)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    break;
            }
            MarketingFirm newFirm = new MarketingFirm(manager);



        }
    }
}
