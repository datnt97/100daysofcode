using System;
using System.Security.Cryptography;

namespace ObserverDesignPattern.Exam
{

    public class MathExam : Exam
    {
        public MathExam(string name, double maxGrade) : base(name, maxGrade)
        {

        }
    }
}