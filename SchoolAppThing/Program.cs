using System;

namespace SchoolAppThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Student FStud = new Student();
            FStud.StuNum = AskStuNum();
            FStud.StuFN = AskStuName("First");
            FStud.StuLN = AskStuName("Last");
            FStud.Major = AskMajor(FStud.StuFN);
            FStud.Score1 = AskExam(1);
            FStud.Score2 = AskExam(2);
            FStud.Score3 = AskExam(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(FStud.ToString());

            Console.WriteLine("\n Second Student \n");
            Student SStud = new Student("2231","Carns","Red");
            SStud.Major = AskMajor(SStud.StuFN);
            SStud.Score1 = AskExam(1);
            SStud.Score2 = AskExam(2);
            SStud.Score3 = AskExam(3);

            Console.WriteLine("Second Student");
            Console.WriteLine(SStud.ToString());

            Student TStud = new Student("234", "Tom", "Tim", "Math", 90, 98, 100);
            Console.WriteLine(TStud.ToString());



        }

        private static string AskMajor(string stuFN)
        {
            string inValue;
            Console.WriteLine("Enter {0}'s Major: ", stuFN);
            inValue = Console.ReadLine();
            return inValue;
        }

        private static int AskExam(int v)
        {
            int inValue;
            Console.WriteLine("Enter a value for score {0}", v);
            inValue = int.Parse(Console.ReadLine());
            return inValue;
        }

        private static string AskStuName(string v)
        {
            string inValue;
            Console.WriteLine("Enter Student's {0} Name: ", v);
            inValue = Console.ReadLine();
            return inValue;
        }

        private static string AskStuNum()
        {
            string inValue;
            Console.WriteLine("Enter Student ID Number: ");
            inValue = Console.ReadLine();
            return inValue;
        }
    }
}
