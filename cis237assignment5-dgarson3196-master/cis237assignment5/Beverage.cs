/*Author: Daniel Garson
CIS 237
Assignment 5
Due: 4-2-18
*/


namespace cis237assignment5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Beverage
    {

        //ID
        [StringLength(10)]
        public string id { get; set; }


        //Name
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        //Pack
        [Required]
        [StringLength(20)]
        public string pack { get; set; }


        //Price
        [Column(TypeName = "money")]
        public decimal price { get; set; }

        //TRUE/FALSE status
        public bool active { get; set; }

        //toString method for formating printed list
        public override string ToString()
        {
            string printString = id.ToString().Trim().PadRight(9) + name.ToString().Trim().PadRight(50) + pack.Trim().PadRight(20) +
               price.ToString("c").Trim().PadRight(10) + active.ToString().Trim();
            return printString;
        }

    }
}
