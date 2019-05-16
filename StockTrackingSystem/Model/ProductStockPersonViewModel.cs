using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Model
{
    public class ProductStockPersonViewModel
    {
        public ProductStockPersonViewModel()
        {
            product = new tblProducts();
            debitedStock = new tblDebitedStock();
            person = new tblPersons();
        }

        public tblProducts product { get; set; }

        public tblDebitedStock debitedStock { get; set; }

        public tblPersons person { get; set; }
    }
}
