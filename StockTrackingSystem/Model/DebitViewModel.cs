using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingSystem.Model
{
    public class DebitViewModel
    {
        public DebitViewModel()
        {
            debit = new tblDebit();
        }

        public tblDebit debit { get; set; }
    }
}
