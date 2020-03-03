using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Variables

        Queue<Sweepstakes> queue;


        public Sweepstakes GetSweepstakes()
        {
            queue.Dequeue();

            return queue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue = new Queue<Sweepstakes>();

            queue.Enqueue(sweepstakes);

        }
    }
}
