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
    class MergeSort { 
   // aux array for merge
        private IComparable[] aux;


    private void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
    {
        if (hi <= lo) return;
        int mid = lo + (hi - lo) / 2;

        // Sort left 
        sort(a, aux, lo, mid);

        //sort right 
        sort(a, aux, mid + 1, hi);

        //merge
        merge(a, aux, lo, mid, hi);
    }


    public void sort(IComparable[] a, int highIndex) //Int highIndex is passed in to determine the length of the aux array being used. 
    {
        aux = new IComparable[highIndex];            // Allocate space just once.
        sort(a, aux, 0, highIndex - 1);
    }


    public void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
    {
        // Merge a[lo..mid] with a[mid+1..hi].
        int i = lo;
        int j = mid + 1;

        for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
        {
            aux[k] = a[k];
        }

        for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
        {
            if (i > mid)
            {
                a[k] = aux[j++];
            }
            else if (j > hi)
            {
                a[k] = aux[i++];
            }
            else if (aux[j].CompareTo(aux[i]) < 0)
            {
                a[k] = aux[j++];
            }
            else a[k] = aux[i++];
        }
    }



}
}
