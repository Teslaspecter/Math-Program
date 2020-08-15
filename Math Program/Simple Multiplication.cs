using System;
//using System.Threading;

namespace Math_Program
{
    class User
    {
        public string name;
        public int cDifficulty; //chosen difficulty
        // difficulties available
        public int additionDifficulty = 1;
        public int subtractionDifficulty = 1;
        public int multiplicationDiffculty = 1;
        public int divisionDifficulty = 1;
        public int combinedDifficulty = 1;

        //addition difficulty method
        public void aDifficulty()
        {
            Console.WriteLine("Please select your difficulty level\n");
            if (additionDifficulty == 1)
            {
                while (cDifficulty != 1)
                {
                    Console.WriteLine("\n1. Beginner");
                    cDifficulty = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (additionDifficulty == 2)
            {
                while (cDifficulty != 1 || cDifficulty !=2)
                {
                    Console.WriteLine("\n1. Beginner \n2. Intermediate");
                    cDifficulty = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (additionDifficulty == 3)
            {
                while (cDifficulty != 1 || cDifficulty != 2 || cDifficulty != 3)
                {
                    Console.WriteLine("\n1. Beginner \n2. Intermediate \n3. Advanced");
                    cDifficulty = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string type; //what type of problem
            int questions; // amuont of questions
            int currentQuestion; //track current question number
            //Introduction
            User player = new User();
            Console.WriteLine("Hello and welcome to Math Challenge!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is your name?");
            player.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + player.name + "!\nPlease select what kind of math problem you'd like to practice.");
            Console.ReadKey();
            Console.Clear();

        //Math Selection
        //1. Addition
        //2. Subtraction
        //3. Multiplication
        //4. Division
        //5. Combination
            askAgain1:
            Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Divsion \n5. Combination\n");
            type = Console.ReadLine();
            Console.Clear();
            if (type == "1" || type == "2" || type == "3" || type == "4" || type == "5") { }
            else
            {
                Console.WriteLine("Please make another selection");
                Console.ReadKey();
                Console.Clear();
                goto askAgain1;
            }

            //How many problems
            askAgain2:
            Console.WriteLine("How many problems would you like to solve?\n");
            questions = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (questions < 10)
            {
                Console.WriteLine("Please select at least 10 problems to solve");
                Console.ReadKey();
                Console.Clear();
                goto askAgain2;
            }

            //Addition Module
            if (type == "1")
            {
                player.aDifficulty();
            }

            //Multiplication Module

            if (type == "3")
            {
                 


                Random numberGenerator = new Random();
            start:
                int num01 = numberGenerator.Next(1, 11);
                int num02 = numberGenerator.Next(1, 11);
                int result = (num01 * num02);
            tryAgain:
                Console.WriteLine("What is " + num01 + " times " + num02 + "?");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer != result)
                {
                    Console.WriteLine("You're so stupid! \nPress spacebar to try again!");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.Clear();
                    goto tryAgain;
                }
                else if (answer == result)
                {
                    Console.WriteLine("You're a genius! \nDo you want to try another problem?");
                yn:
                    string decision = Console.ReadLine();
                    if (decision == "yes" || decision == "y")
                    {
                        Console.WriteLine();
                        Console.Clear();
                        goto start;
                    }
                    if (decision == "no" || decision == "n")
                    {
                        Console.WriteLine("Good Job! You're multiplication skills are top notch!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please write yes or no.");
                        goto yn;
                    }
                }
            }
        }
    }
}
