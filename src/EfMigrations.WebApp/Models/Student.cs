namespace EfMigrations.WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Student()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Subject = string.Empty;
        }
    }
}
