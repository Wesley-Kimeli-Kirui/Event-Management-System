namespace EventsApplication.Response
{
    public class EventsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Slots { get; set; }
        public double Price { get; set; }
        public DateTime EventDate { get; set; } = DateTime.Now;
    }
}