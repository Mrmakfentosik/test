using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK2.Model
{
    class VariantsRentGetby
    {
        public int Id { get; set; }
        public AdvtRent AdvtRentId { get; set; }
        public AdvtGetby AdvtGetbyId { get; set; }
    }
}
