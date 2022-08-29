namespace DynamicDataModeling.Models
{
    public class Contact
    {
        public int Id { get; set; }

        // Navigation props
        public int UserId { get; set; }
        public User? User { get; set; }

        public int GlobalTypeId { get; set; }

        public GlobalType? GlobalType { get; set; }
    }
}
