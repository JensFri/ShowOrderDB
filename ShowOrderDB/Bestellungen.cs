using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowOrderDB
{
    public partial class Bestellungen
    {
        public int OrderID { get; set; }
        
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }
    }
}
