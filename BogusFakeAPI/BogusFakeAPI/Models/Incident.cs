namespace BogusFakeAPI.Models
{
    public class Incident
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime ReportedOn { get; set; }
        public Contact ReportedBy { get; set; }
    }
}
