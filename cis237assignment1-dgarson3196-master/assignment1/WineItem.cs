/* Daniel Garson
 * CIS 237
 * 1/24/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem { 
     private string id;
        private string type;
        private string ammount;


     





      
        public override string ToString()
        {
            return id + " " + type + " " + ammount;
        }

        

        public WineItem(string ID, string TY, string AMT)
        {
            this.id = ID;
            this.type = TY;
            this.ammount = AMT;
           
            
            
        }

       



       



    }
}

