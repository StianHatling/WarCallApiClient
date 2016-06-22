namespace WarCallApiClient.Models
{
    public class WebAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountName { get; private set; }
        public string AccountCountry { get; private set; }

        public WebAccount(int number, string name, string country)
        {
            AccountNumber = number;
            AccountName = name;
            AccountCountry = country;
        }
    }
}