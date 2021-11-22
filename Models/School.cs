namespace SchoolManager.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public long SchoolID { get; set; }
        public string Region { get; set; }
        public int Teachers { get; set; }
        public int Vacancies { get; set; }

        public School()
        {

        }
    }
}
