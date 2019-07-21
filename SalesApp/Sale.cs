using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class Sale : BaseModel  //everything in BaseModel now in Sale
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }


        //Sale has one SalesPerson.
        public virtual SalesPerson Person { get; set; }  //virtual: add extra code in it to track when the property will change.

        [Required]
        public int PersonId { get; set; }


        //Sale has one SalesRegion.
        public virtual SalesRegion Region { get; set; }  //virtual: add extra code in it to track when the property will change.

        [Required]
        public int RegionId { get; set; }

        //one-to-one relationship: sale to salesperson, salesregion

    }
}
