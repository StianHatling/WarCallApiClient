using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCallApiClient.Models
{
    class Insurance
    {
        public int? ID { get; private set; }
        public string ExternalReference { get; private set; }
        public int InsuranceYear { get; private set; }
        public string Currency { get; private set; }
        public double Value { get; private set; }
        public double Rate { get; private set; }
        public double Share { get; private set; }
        public InterestCode InterestCode { get; private set; }
        public WebObject InsuranceObject { get; private set; }
        public Fleet InsuranceFleet { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public WebAccount Client { get; private set; }
        public WebAccount Insured { get; private set; }
        public string AlterationText { get; private set; }
        public string AlterationDescription { get; private set; }
        public string AutoClose { get; private set; }
        public Ins2000Reference Ins2000Reference { get; private set; }
        public int? Status { get; private set; }
        public string LastModifiedByUser { get; private set; }
        public int? BatchID { get; private set; }
        public string ErrorMessage { get; private set; }

        public Insurance(int? id, string externalReference, int insuranceYear, string currency, double value, double rate, double share, InterestCode interestCode, WebObject insuranceObject,
                        Fleet insuranceFleet, DateTime fromDate, DateTime toDate, WebAccount client, WebAccount insured, string alterationText, string alterationDescription, string autoClose,
                        Ins2000Reference ins2000Reference, int? status, string lastModifiedByUser, int? batchID, string errorMessage)
        {
            ID = id;
            ExternalReference = externalReference;
            InsuranceYear = insuranceYear;
            Currency = currency;
            Value = value;
            Rate = rate;
            Share = share;
            InterestCode = interestCode;
            InsuranceObject = insuranceObject;
            InsuranceFleet = insuranceFleet;
            FromDate = fromDate;
            ToDate = toDate;
            Client = client;
            Insured = insured;
            AlterationText = alterationText;
            AlterationDescription = alterationDescription;
            AutoClose = autoClose;
            Ins2000Reference = ins2000Reference;
            Status = status;
            LastModifiedByUser = lastModifiedByUser;
            BatchID = batchID;
            ErrorMessage = errorMessage;
        }

        public static Insurance GetTestInsurance()
        {
            int? id = null;
            string externalReference = "";
            int insuranceYear = 2016;
            string currency = "CAD";
            double value = 1000000.00d;
            double share = 100d;
            double rate = 0.750d;
            InterestCode interestCode = new InterestCode(501, "WarCall");
            WebObject obj = new WebObject(null, 63479, "ZEALOT", "FFS", null);
            Fleet fleet = new Fleet(null, "FARSTAD SHIPPING ASA", 2016, "ITS");
            DateTime fromDate = new DateTime(2016, 01, 01);
            DateTime toDate = new DateTime(2016, 6, 15);
            WebAccount client = new WebAccount(2404562, "FARSTAD SHIPPING ASA", "NOR");
            WebAccount insured = new WebAccount(666, "Test Unknown Account", "FRA");
            string alterationText = "";
            string alterationDescription = "WARWEBCALL";
            string autoClose = null;
            Ins2000Reference ins2000Reference = new Ins2000Reference(null, 2016, 1, 0, 20160067, 362, "30");
            int? status = null;
            string lastModifiedByUser = "STH";
            int? batchID = null;
            string errorMsg = "";

            Insurance ins = new Insurance(id, externalReference, insuranceYear, currency, value, rate, share, interestCode,
                                           obj, fleet, fromDate, toDate, client, insured, alterationText, alterationDescription,
                                           autoClose, ins2000Reference, status, lastModifiedByUser, batchID, errorMsg);
            return ins;
        }
    }
}
