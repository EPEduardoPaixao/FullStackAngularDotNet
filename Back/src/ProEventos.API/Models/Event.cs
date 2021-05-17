namespace ProEventos.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string DateEvent { get; set; }
        public string Theme { get; set; }
        public int QtdPeople { get; set; }
        public string Batch { get; set; }
        public string ImageUrl { get; set; }
        
    }
}