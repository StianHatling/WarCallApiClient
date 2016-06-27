using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    class InsuranceHandler
    {
        public int? ID { get; private set; }
        public string Domain { get; private set; }
        public string Owner { get; private set; }

        public InsuranceHandler(int? id, string domain, string owner)
        {
            ID = id;
            Domain = domain;
            Owner = owner;
        }
    }
}
