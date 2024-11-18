using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Software_Testing
{
    public class Location
    {
        public int LocationId { get; set; }
        public static int numberOfLocations = 0;
        public List<int> products = new List<int>();

        public Location()
        {
            LocationId = numberOfLocations;
            numberOfLocations++;
            WarehouseInventory.Locations.Add(this);
        }
    }
}
