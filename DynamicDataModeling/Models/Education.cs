namespace DynamicDataModeling.Models
{
    public class Education
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
