using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTicketCS29 {
    class Ticket {

        static int studentNum;
        static int speedLimit;
        static int ticketSpeed;
        static double price;
        static Classes grade;

        enum Classes {
            Freshman,
            Sophomore,
            Junior,
            Senior
        }

        public static void NewTicket() {
            Console.WriteLine("Enter Student Number: ");
            studentNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed Limit");
            speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed of Student");
            ticketSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade by Number: 0 - Freshman, 1 - Sophomore, 2 - Junior, 3 - Senior");
            switch (int.Parse(Console.ReadLine())) {
                case 0:
                    grade = Classes.Freshman;
                    break;
                case 1:
                    grade = Classes.Sophomore;
                    break;
                case 2:
                    grade = Classes.Junior;
                    break;
                case 3:
                    grade = Classes.Senior;
                    break;
            }
            CalcFine();
            PrintTicket();
        }

        private static void CalcFine() {
            price = 75;
            int milesdifference = (ticketSpeed - speedLimit);
            int miles5 = (ticketSpeed - speedLimit) / 5;
            price += miles5 * 87.5;

            

            if(grade == Classes.Freshman) {
                if (milesdifference < 20)
                    price -= 50;
                else price += 100;
            }
            if(grade == Classes.Senior) {
                if (milesdifference > 20)
                    price += 200;
                else price += 50;
            }
            if (grade == Classes.Junior || grade == Classes.Sophomore) {
                if (milesdifference >= 20) price += 100;
            }


        }

        private static void PrintTicket() {
            Console.Clear();
            Console.WriteLine("Student Number: " + studentNum);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Speed Limit: " + speedLimit);
            Console.WriteLine("Reported Speed: " + ticketSpeed);
            Console.WriteLine("Fine: " + price);

            Console.WriteLine("Press any Key for Another Ticket");
            Console.ReadKey();
            Console.Clear();
            NewTicket();
        }


    }
}
