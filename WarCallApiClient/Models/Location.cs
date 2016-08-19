using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    public class Location
    {
        public int? LocationID { get; private set; }
        public int BusinessUnit { get; private set; }
        public string CountryCode { get; private set; }
        public string LocationCode { get; private set; }
        public string Status { get; private set; }

        public Location(int? id, int busunit, string country, string loccode, string status)
        {
            LocationID = id;
            BusinessUnit = busunit;
            CountryCode = country;
            LocationCode = loccode;
            Status = status;
        }
    }
}
