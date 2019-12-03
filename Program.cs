using System;

namespace MathGameNew
{
    class Program
    {
        static Random r = new Random();

        private static void Addition()
        {
            int score = 0;

            Start:

            int n1 = r.Next(1, 10);
            int n2 = r.Next(1, 10);

            Console.WriteLine(n1 + " + " + n2 + " = " + "? ");
            Console.WriteLine("");
            int answer = Convert.ToInt32(Console.ReadLine());
            int result = n1 + n2;


            if (answer == result)
            {
                score = score + 10;
                Console.WriteLine("Correct! Score: " + score);
            }
            else
            {
                score = score - 10;
                Console.WriteLine("Incorrect:( The right answer is: " + result + ". " + "Score: " + score);
            }
            goto Start;

        }

        private static void Substraction()
        {
            int score = 0;

        Start:

            int n1 = r.Next(1, 10);
            int n2 = r.Next(1, 10);

            Console.WriteLine(n1 + " - " + n2 + " = " + "? ");
            Console.WriteLine("");
            int answer = Convert.ToInt32(Console.ReadLine());
            int result = n1 - n2;


            if (answer == result)
            {
                score = score + 10;
                Console.WriteLine("Correct! Score: " + score);
            }
            else
            {
                score = score - 10;
                Console.WriteLine("Incorrect:( The right answer is: " + result + ". " + "Score: " + score);
            }
            goto Start;

        }

        private static void Multiplication()
        {
            int score = 0;

        Start:

            int n1 = r.Next(2, 9);
            int n2 = r.Next(2, 9);

            Console.WriteLine(n1 + " x " + n2 + " = " + "? ");
            Console.WriteLine("");
            int answer = Convert.ToInt32(Console.ReadLine());
            int result = n1 * n2;


            if (answer == result)
            {
                score = score + 10;
                Console.WriteLine("Correct! Score: " + score);
            }
            else
            {
                score = score - 10;
                Console.WriteLine("Incorrect:( The right answer is: " + result + ". " + "Score: " + score);
            }
            goto Start;

        }

        private static void Division()
        {
            int score = 0;

        Start:

            int r1 = r.Next(2, 9);
            int r2 = r.Next(2, 9);

            int x = r1 * r2;

            int n1 = x;
            int n2 = x / r2;

            Console.WriteLine(n1 + " : " + n2 + " = " + "? ");
            Console.WriteLine("");
            int answer = Convert.ToInt32(Console.ReadLine());
            int result = n1 / n2;


            if (answer == result)
            {
                score = score + 10;
                Console.WriteLine("Correct! Score: " + score);
            }
            else
            {
                score = score - 10;
                Console.WriteLine("Incorrect:( The right answer is: " + result + ". " + "Score: " + score);
            }
            goto Start;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to the Math Game!***");
            Console.WriteLine("");
            Console.WriteLine("Please choose the level: ");
            Console.WriteLine("");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:

                    Console.WriteLine("");
                    Console.WriteLine("You chose Addition, let's start: ");
                    Console.WriteLine("");

                    Addition(); break;

            }

            switch (choice)
            {
                case 2:

                    Console.WriteLine("");
                    Console.WriteLine("You chose Substraction, let's start: ");
                    Console.WriteLine("");

                    Substraction(); break;

            }

            switch (choice)
            {
                case 3:

                    Console.WriteLine("");
                    Console.WriteLine("You chose Multiplication, let's start: ");
                    Console.WriteLine("");

                    Multiplication(); break;

            }

            switch (choice)
            {
                case 4:

                    Console.WriteLine("");
                    Console.WriteLine("You chose Division, let's start: ");
                    Console.WriteLine("");

                    Division(); break;

            }
        }
    }
}
