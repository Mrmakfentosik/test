using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK2.Model
{
    public class AdvtGetby
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int HausTypeId { get; set; }
        public int Floor { get; set; }
        public int NumberOfRooms { get; set; }
        public int SQ { get; set; }
        public string Adress { get; set; }
        public int DistrictId { get; set; }
        public DateTime MinArenda { get; set; }
        public DateTime MaxArenda { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
