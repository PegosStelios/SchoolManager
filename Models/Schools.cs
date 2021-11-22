namespace SchoolManager.Models
{
    public class Schools
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolID { get; set; }
        public string Region { get; set; }
        public int Teachers { get; set; }
        public int Students { get; set; }
        public int Vacancies { get; set; }

        public Schools()
        {

        }
    }
}
