using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    public class Visit
    {
        public int CompanyNumber { get; private set; }
        public int? Seqnum { get; private set; }
        public string CompanyName { get; private set; }
        public DateTime VisitDate { get; private set; }
        public string Comments { get; private set; }
        public DateTime LastChanged { get; private set; }
        public string UserId { get; private set; }
        public int NumberOfParticipants { get; private set; }
        public string Segment { get; private set; }
        public string Planned { get; private set; }
        public Location Location { get; private set; }
        public string VisitBy { get; private set; }
        public string VisitWho { get; private set; }
        public int VisitType { get; private set; }
        public int? InsuranceYear { get; private set; }
        public string FleetName { get; private set; }
        public int? RiskNumber { get; private set; }
        public int? ClaimNumber { get; set; }
        public int? Covernote { get; private set; }
        public int? ModuleID { get; private set; }


        public Visit(int cmpnum, int? seqnum, string cmpnam, DateTime visitdate, string comments, DateTime lastchg, string user_id,
                     int numofpart, string segment, string planned, Location location, string visitby, string visitwho, int visittype,
                     int? modyear, string fleetnam, int? risknum, int? clmnum, int? covnot, int? modid)
        {
            CompanyNumber = cmpnum;
            Seqnum = seqnum;
            CompanyName = cmpnam;
            VisitDate = visitdate;
            Comments = comments;
            LastChanged = lastchg;
            UserId = user_id;
            NumberOfParticipants = numofpart;
            Segment = segment;
            Planned = planned;
            Location = location;
            VisitBy = visitby;
            VisitWho = visitwho;
            VisitType = visittype;
            InsuranceYear = modyear;
            FleetName = fleetnam;
            RiskNumber = risknum;
            ClaimNumber = clmnum;
            Covernote = covnot;
            ModuleID = modid;
        }

        internal static Visit GetSampleVisit()
        {
            int cmpnum = 1002823;
            int? seqnum = 3185;
            string cmpnam = "Team Tankers";
            DateTime visitdate = new DateTime(2016, 08, 18);
            string comment = "Comment";
            DateTime lastchg = new DateTime(2016, 08, 18);
            string userid = "STH";
            int numofpart = 4;
            string segment = "Segment";
            string planned = "Y";
            Location location = new Location(null, 30, "NOR", "Bergen sentrum", null);

            string visitby = ArrayToString(new string[]{ "Stian Hatling", "Morten Forland" });
            string vititwho = ArrayToString(new string[] { "Person A", "Person B" });
            int visittype = 1;
            int? modyear = 2016;
            string fleetnam = "FARSTAD SHIPPING ASA";
            int? risknum = null;
            int? clmnum = null;
            int? covnot = null;
            int? modid = null;

            return new Visit(cmpnum, seqnum, cmpnam, visitdate, comment, lastchg, userid, numofpart, 
                             segment, planned, location, visitby, vititwho, visittype, modyear, fleetnam, 
                             risknum, clmnum, covnot, modid);

        }

        static string ArrayToString(string[] array)
        {
            return string.Join(", ", array);
        }
    }
}
