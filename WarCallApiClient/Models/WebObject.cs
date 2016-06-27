using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    class WebObject
    {
        public int? ID { get; private set; }
        public int Imonumber { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int? Tonnage { get; private set; }

        public WebObject(int? id, int imonumber, string name, string type, int? tonnage)
        {
            ID = id;
            Imonumber = imonumber;
            Name = name;
            Type = type;
            Tonnage = tonnage;
        }
    }
}
