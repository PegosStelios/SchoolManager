namespace SchoolManager.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectId { get; set; }
        public string StudentAmount { get; set; }
        public string RequiredGrade { get; set; }
        public string RequiredHours { get; set; }
        public string RequiredTests { get; set; }
        public string TotalTests { get; set; }
        public string TotalHours { get; set; }
        public string MaxAbsentHours { get; set; }
        public string TeacherCountInClass { get; set; }
        public string TeacherRegistered { get; set; }
        public string Department { get; set; }

        public Subjects()
        {

        }
    }
}
