using System;
using System.Collections.Generic;

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

        public Dictionary<string, string> Labels = new Dictionary<string, string>();
        public Subjects(string Department, string StudentAmount, string RequiredGrade, string RequiredHours, string TeacherRegistered)
        {
            this.Department = Department;
            this.StudentAmount = StudentAmount;
            this.RequiredGrade = RequiredGrade;
            this.RequiredHours = RequiredHours;
            this.TeacherRegistered = TeacherRegistered;

            this.Labels.Add("Τομέας", this.Department);
            this.Labels.Add("Ποσότητα Μαθητών", this.StudentAmount);
            this.Labels.Add("Ελάχιστος Βαθμός", this.RequiredGrade);
            this.Labels.Add("Ελάχιστές Διδακτικές Ώρες", this.RequiredHours);
            this.Labels.Add("Ποσότητα Καθηγητών", this.TeacherRegistered);
        }
    }
}
