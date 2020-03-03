using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //Variables

        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;   
        }
        public void CreateSweepstakes()
        {
           
            Sweepstakes sweepstakes = new Sweepstakes();
            Console.WriteLine("Enter Sweepstakes Name: ");
            sweepstakes.Name = Console.ReadLine();
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}