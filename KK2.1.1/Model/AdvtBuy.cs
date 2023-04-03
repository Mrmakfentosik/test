using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KK2.Model;

namespace KK2.Model
{
    public class AdvtBuy
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int HausTypeId { get; set; }
        public int MinFlor { get; set; }
        public int MaxFlor { get; set; }
        public int MinNumberRows { get; set; }
        public int MaxNumberRows { get; set; }
        public int DistrictId { get; set; }
        public string Description { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}
