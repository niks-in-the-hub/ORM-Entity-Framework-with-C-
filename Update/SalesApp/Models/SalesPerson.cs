using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class SalesPerson : BaseModel, IActive //everything in BaseModel, IActive now in SalesPerson
    {
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }


        //SalesPerson has one SalesRegion.
        public virtual SalesRegion Region { get; set; }  //virtual: add extra code in it to track when the property will change.

        [Required]
        public int RegionId { get; set; }

        //one-to-one relationship: salesperson to salesregion

        public virtual ObservableListSource<Sale> Sales { get; set; }  //SalesPerson has multiple Sale.

        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

        public string FullName   //read only property to get full name of the sales person.
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }

    }
}
