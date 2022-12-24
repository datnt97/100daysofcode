using System.Collections.Generic;

namespace ObserverDesignPattern.Exam
{
    public abstract class Exam
    {
        private List<Student> students = new List<Student>();

        private double maxGrade = 4;
        private string name;

        protected Exam(string name, double maxGrade)
        {
            this.name = name;
            this.maxGrade = maxGrade;
        }

        public double MaxGrade
        {
            get => maxGrade;
            set
            {
                double olderMaxGrade = maxGrade;
                maxGrade = value;
                NotifyMaxGradeChanged(olderMaxGrade);
            }
        }

        public void Attach(Student student)
        {
            students.Add(student);
        }

        public void Detach(Student student)
        {
            students.Remove(student);
        }

        public void NotifyMaxGradeChanged(double oldMaxGrade)
        {
            foreach (Student student in students)
            {
                student.CalculateRateOfGrade(this, oldMaxGrade);
            }
        }


    }
}