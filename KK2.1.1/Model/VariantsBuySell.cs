using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK2.Model
{
    class VariantsBuySell
    {
        public int Id { get; set; }
        public AdvtBuy AdvtBuyId { get; set; }
        public AdvtSell AdvtSellId { get; set; }
    }
}
