using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAppThing
{
    class Student
    {
        private string stuNum, stuLN, stuFN, major;
        private int score1, score2, score3;

        public Student()
        {

        }
        public Student(string sID)
        {
            stuNum = sID;
        }
        public Student(string sID, string LN, string FN)
        {
            stuNum = sID;
            stuLN = LN;
            stuFN = FN;
        }
        public Student(string sID, string LN, string FN, string major, int Score1, int Score2, int Score3)
        {
            stuNum = sID;
            stuLN = LN;
            stuFN = FN;
            this.major = major;
            score1 = Score1;
            score2 = Score2;
            score3 = Score3;

        }

        public string StuNum { get => stuNum; set => stuNum = value; }
        public string StuLN { get => stuLN; set => stuLN = value; }
        public string StuFN { get => stuFN; set => stuFN = value; }
        public string Major { get => major; set => major = value; }
        public int Score1 { get => score1; set => score1 = value; }
        public int Score2 { get => score2; set => score2 = value; }
        public int Score3 { get => score3; set => score3 = value; }

        public double CalcAverage()
        {
            return (score1 + score2 + score3) / 3;
        }

        public override string ToString()
        {
            return $"Name : {stuFN} {stuLN}\nMajor : {major}\n" +
                $"Score Average :" + CalcAverage().ToString("F2");

        }
    }
}
