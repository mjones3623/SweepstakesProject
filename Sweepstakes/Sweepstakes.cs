using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        //Variables

        private string name;

        //name property
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructor

        public Sweepstakes()
        {
            name = "";


        }

        //Methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = UserInterface.GetUserInputInt("Enter contestant's REGISTRATION NUMBER, then press enter:  ");
            contestant.firstName = UserInterface.GetUserInputString ("Enter FIRST NAME of contestant, then hit enter: ");
            contestant.lastName= UserInterface.GetUserInputString("Enter LAST NAME of contestant, then hit enter: ");
            contestant.emailAddress = UserInterface.GetUserInputString("Enter contestant's EMAIL ADDRESS, then hit enter: ");

            contestants.Add(contestant.registrationNumber, contestant);
           
            
        }
        public Contestant ChooseContestWinner(Contestant contestant)
        {
            List < Contestant > SweepstakesList = new List<Contestant>();
            foreach (KeyValuePair<int, Contestant>pair in contestants)
            {
                SweepstakesList.Add(pair.value);
                
            }
            return contestant;

        }

    }
}
