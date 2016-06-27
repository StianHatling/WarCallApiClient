using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    public class Fleet
    {
        public int? ID { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string Domain { get; private set; }

        public Fleet(int? id, string name, int year, string domain)
        {
            ID = id;
            Name = name;
            Year = year;
            Domain = domain;
        }
    } 

}
