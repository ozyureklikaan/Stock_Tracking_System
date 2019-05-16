using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Model
{
    public class DebitProductStockPersonViewModel
    {
        public DebitProductStockPersonViewModel()
        {
            debit = new tblDebit();
            product = new tblProducts();
            stock = new tblStock();
            person = new tblPersons();
        }

        public tblDebit debit { get; set; }

        public tblProducts product { get; set; }

        public tblStock stock { get; set; }

        public tblPersons person { get; set; }
    }
}
