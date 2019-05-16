using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Model
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            product = new tblProducts();
        }

        public tblProducts product { get; set; }
    }
}
