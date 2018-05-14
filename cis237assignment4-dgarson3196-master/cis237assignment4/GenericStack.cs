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
    class GenericStack<T>
    {

        //top of stack
        private GenericNode<T> top;

        //number of items
        private int Num;

        public bool Empty()
        { return top == null; }


        public int size()
        { return Num; }
        //adds to top of stack
        public void Push(T item)
        {
            GenericNode<T> first = top;

            //create a new node
            top = new GenericNode<T>();
            top.Data = item;
            top.Next = first;

            //increment the size
            Num++;
        }
        //get data from the first node
        public T Pop()
        {
            T Data = top.Data;
            top = top.Next;
            Num--;
            return Data;
        }
    }
}
