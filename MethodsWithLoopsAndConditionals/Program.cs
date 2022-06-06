using System;

namespace MethodsWithLoopsAndConditionals
{

    class Program
    {

        // Write a method that will print to the console all numbers 1000 through -1000.
        public static void DisplayNums()
        {
            var num = -1000;

            do
            {
                num++;
                Console.WriteLine(num);

            } while (num < 1000);
        }


        // Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void DisplayBy3s()
        {
            for (int num = 3; num < 1000; num += 3)
            {
                Console.WriteLine(num);
            }
        }


        // Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void CheckEqualOrNot(int num1, int num2)
        {
            var result = num1 == num2 ? "These two number are equal to each other" : "These two numbers are NOT equal to each other";
            Console.WriteLine(result);
        }


        // Write a method to check whether a given number is even or odd.
        public static void CheckEvenOrOdd(int num)
        {
            var result = num % 2 == 0 ? $"The number {num} is Even" : $"The number {num} is Odd";
            Console.WriteLine(result);
        }


        // Write a method to check whether a given number is positive or negative.
        public static void CheckNegativeOrPositive(int num)
        {
            var result = num < 0 ? $"The {num} is Negative" : $"The {num} is Positive";
            Console.WriteLine(result);
        }


        // Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void VerifyingAge()
        {
            Console.WriteLine("What is your age? ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userAge))
            {
                var result = userAge < 18 ? "I'm sorry to inform you, but you are not able to vote because you are underage." : "Who would you like to cast your vote for?";
                Console.WriteLine(result);

            } else
            {
                Console.WriteLine("Invalid Input!");
            }
        }


        // Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void VerifyingInputRange()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number between -10 and 10");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userNum))
                {
                    if (userNum < -10 || userNum > 10)
                    {
                        Console.WriteLine("Your number is not within the parameters!");

                    } else
                    {
                        Console.WriteLine("Valid Entry");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid Input!");
                }

            }

        }


        // Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void DisplayMultiplicationTable()
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userNum))
                {
                    if (userNum < 0 || userNum > 12)
                    {
                        Console.WriteLine("Error, Please enter a number between 1 and 12");

                    }
                    else
                    {
                        Console.WriteLine("--------- Multiplication Table ---------");
                        Console.WriteLine($"{userNum} x 1 = {userNum * 1}");
                        Console.WriteLine($"{userNum} x 2 = {userNum * 2}");
                        Console.WriteLine($"{userNum} x 3 = {userNum * 3}");
                        Console.WriteLine($"{userNum} x 4 = {userNum * 4}");
                        Console.WriteLine($"{userNum} x 5 = {userNum * 5}");
                        Console.WriteLine($"{userNum} x 6 = {userNum * 6}");
                        Console.WriteLine($"{userNum} x 7 = {userNum * 7}");
                        Console.WriteLine($"{userNum} x 8 = {userNum * 8}");
                        Console.WriteLine($"{userNum} x 9 = {userNum * 9}");
                        Console.WriteLine($"{userNum} x 10 = {userNum * 10}");
                        Console.WriteLine($"{userNum} x 11 = {userNum * 11}");
                        Console.WriteLine($"{userNum} x 12 = {userNum * 12}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a digit");
                }

            }
        }


        static void Main(string[] args)
        {
            // DisplayNums();
            // DisplayBy3s();
            // CheckEqualOrNot(2, 2);
            // CheckEvenOrOdd(45);
            // CheckNegativeOrPositive(-56);
            // VerifyingAge();
            // VerifyingInputRange();
            DisplayMultiplicationTable();
        }
    }
}

