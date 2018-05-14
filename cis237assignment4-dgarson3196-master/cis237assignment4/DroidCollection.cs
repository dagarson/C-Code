/* Daniel Garson
 * CIS 237 
 * Due: 3/19/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cis237assignment4
{

    class DroidCollection
    {
        //droid collection array
        Droid[] DCollection;
        Droid[] auxCollection;
        int highestValue;
        int DCLength;

        //bucketsort incrementer
        int BSI = 0;



        // new instances of all the stacks 
        GenericStack<Droid> protocolStack = new GenericStack<Droid>();
        GenericStack<Droid> astromechStack = new GenericStack<Droid>();
        GenericStack<Droid> janitorialStack = new GenericStack<Droid>();
        GenericStack<Droid> utilityStack = new GenericStack<Droid>();
        GenericQueue<Droid> genericQueue = new GenericQueue<Droid>();


        //determine how many  droid in droid collection array. 
        public int Highest
        {
            get { return highestValue; }
            set { highestValue = value; }
        }

        // collect into an array
        public DroidCollection(int Arraysize)
        {
            DCollection = new Droid[Arraysize];
            DCLength = 0;
        }



        // adds a new droid to droid collections 
        public void Add(Droid NDroid)
        {
            DCollection[DCLength] = NDroid;

            //increment length and highest value
            DCLength++;
            highestValue++;
        }



        public void BucketSort()
        {


            auxCollection = new Droid[highestValue];
            for (int i = 0; i < highestValue; i++)
            {
                auxCollection[i] = DCollection[i];
            }
            // push droids onto the appropriate stack
            foreach (Droid droid in auxCollection)
            {
                if (droid.Model == "Astromech")
                {
                    astromechStack.Push(droid);
                }
                if (droid.Model == "Janitor")
                {
                    janitorialStack.Push(droid);
                }
                if (droid.Model == "Utility")
                {
                    utilityStack.Push(droid);
                }
                if (droid.Model == "Protocol")
                {
                    protocolStack.Push(droid);
                }
            }
            while (astromechStack.size() != 0)
                genericQueue.Endqueue(astromechStack.Pop());

            while (janitorialStack.size() != 0)
                genericQueue.Endqueue(janitorialStack.Pop());

            while (utilityStack.size() != 0)
                genericQueue.Endqueue(utilityStack.Pop());

            while (protocolStack.size() != 0)
                genericQueue.Endqueue(protocolStack.Pop());

            BSI = 0;
            // dequeue all the droids back into the original DCollection array 
            while (genericQueue.size() != 0)
            {

                DCollection[BSI] = genericQueue.queue();
                BSI++;
            }


        }

        public void MergeSort()
        {
            MergeSort merge = new MergeSort();


            //pass in highestValue and DCollection
            merge.sort(DCollection, highestValue);
        }

        public string[] DisplayItems()
        {
            //get all items to string 
            string[] all = new string[DCLength];
            int i = 0;

            if (DCLength > 0)
            {
                foreach (Droid droid in DCollection)
                {
                    if (droid != null)
                    {
                        all[i] = droid.ToString();
                        i++;
                    }
                }
            }
            return all;
        }



        //displays all droids
        public void DisplayDroids(string[] Output)
        {
            Console.WriteLine();
            foreach (string itemOutput in Output)
            {
                Console.WriteLine(itemOutput);
            }

        }
    }

}
