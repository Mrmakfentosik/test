using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK2.Model
{
    public class AdvtRent
    {
        public int Id { get; set; }
        public int HausTypeId { get; set; }
        public int UserId { get; set; }
        public int MinFlor { get; set; }
        public int MaxFlor { get; set; }
        public int MinNumberRows { get; set; }
        public int MaxNumberRows { get; set; }
        public int DistrictId { get; set; }
        public DateTime MinArenda { get; set; }
        public DateTime MaxArenda { get; set; }
        public string Description { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}
