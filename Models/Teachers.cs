namespace SchoolManager.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Region { get; set; }
        public string SchoolName { get; set; }
        public string Subject { get; set; }
        public int WorkHours { get; set; }
        public int SickHours { get; set; }
        public bool isPrincipal { get; set; }

        public Teachers()
        {

        }
    }
}
