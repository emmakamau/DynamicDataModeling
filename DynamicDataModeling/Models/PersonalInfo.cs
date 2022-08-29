namespace DynamicDataModeling.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
