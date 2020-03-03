using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant contestant = new Contestant();
            SweepstakesQueueManager Queue = new SweepstakesQueueManager();
            SweepstakesStackManager Stack = new SweepstakesStackManager();


            MarketingFirm marketingFirm = new MarketingFirm(Stack);



            sweepstakes.RegisterContestant(contestant);
        }
    }
}
