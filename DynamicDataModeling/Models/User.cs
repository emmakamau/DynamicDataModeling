namespace DynamicDataModeling.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation options
        public List<Contact> Contacts { get; set; }
        
        public List<Education> EducationList { get; set; }

        public List<PersonalInfo> PersonalInfoList { get; set; }

    }
}
