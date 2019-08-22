using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class SalesRegion : BaseModel, IActive //everything in BaseModel, IActive now in SalesRegion
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; }  //SalesRegion with multiple SalesPerson.

        public virtual ObservableListSource<Sale> Sales { get; set; }  //SalesRegion has multiple Sale.

        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

    }
}
