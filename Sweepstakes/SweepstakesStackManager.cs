using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        //Variables

        Stack<Sweepstakes> stack;

        //Constructor

        
        //Methods
        
        public Sweepstakes GetSweepstakes()
        {
            stack.Peek();
            stack.Pop();

            return stack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
;