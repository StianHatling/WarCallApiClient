using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    class Ins2000Reference
    {
        public int? ID { get; private set; }
        public int Insyear { get; private set; }
        public int MainID { get; private set; }
        public int ChangeID { get; private set; }
        public int Covernote { get; private set; }
        public int ObjectNumber { get; private set; }
        public string BusinessUnit { get; private set; }

        public Ins2000Reference(int? id, int insyear, int mainId, int changeId, int covernote, int objectNumber, string businessUnit)
        {
            ID = id;
            Insyear = insyear;
            MainID = mainId;
            ChangeID = changeId;
            Covernote = covernote;
            ObjectNumber = objectNumber;
            BusinessUnit = businessUnit;
        }
    }
}
