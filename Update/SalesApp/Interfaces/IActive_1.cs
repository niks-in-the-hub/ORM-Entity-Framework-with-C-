using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    interface IActive
    {
        bool Active { get; set; } //Allows to set to true of false. If true, item is active. Else, false
    }
}
