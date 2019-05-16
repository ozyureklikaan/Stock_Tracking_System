using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Model
{
    public class ProductStockViewModel
    {
        public ProductStockViewModel()
        {
            product = new tblProducts();
            stock = new tblStock();
        }

        public tblProducts product { get; set; }
        public tblStock stock { get; set; }
    }
}
