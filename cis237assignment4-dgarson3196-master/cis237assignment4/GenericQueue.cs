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

    class GenericQueue<T>
    {
        //link oldest added node
        private GenericNode<T> oldest;

        //link newest added node
        private GenericNode<T> newest;

        //number of items on queue
        private int Num;

        public bool Empty() { return oldest == null; }
        public int size() { return Num; }

        public void Endqueue(T item)
        {
            //Add  to the end of list.   

            GenericNode<T> last = newest;

            //create a new node 
            newest = new GenericNode<T>();
            newest.Data = item;
            newest.Next = null;

            //check if empty
            if (Empty()) oldest = newest;
            else last.Next = newest;

            //increment the num
            Num++;
        }


        public T queue()
        {
            //Get the data off the node
            T Data = oldest.Data;

            oldest = oldest.Next;
            //make newest null if empty
            if (Empty()) newest = null;
            //decrement that num
            Num--;

            return Data;
        }
    }
}

