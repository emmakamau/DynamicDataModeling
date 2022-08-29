namespace DynamicDataModeling.Models
{
    public class GlobalType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TableName { get; set; }
        
        public string Type { get; set; }

        // Navigation Props
        public List<Contact>? Contacts { get; set; } 
    }
}
