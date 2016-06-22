namespace WarCallApiClient.Models
{
    public class InterestCode
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public InterestCode(int id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}