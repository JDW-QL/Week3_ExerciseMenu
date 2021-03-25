using System;
using System.Collections.Generic;
using System.Threading;

namespace Week_3_Excercises
{
    class Program
    {
        static void Exercise31(List<bool> completed)
        {
         /* int[] arr = { 2, 8, 0, 24, 51 };
            int userIndex;
            bool repeat = true;

            while (repeat == true)
            {
                string useryn = "";
                Console.Write("Enter the index of the array: ");
                userIndex = Convert.ToInt32(Console.ReadLine());
                if (userIndex >= 0 && userIndex < arr.Length)
                    Console.WriteLine($"The value at index {userIndex} is {arr[userIndex]}.");
                else
                    Console.WriteLine("That is not a valid index.");
                while (useryn != "y" && useryn != "n")
                {
                    Console.Write("Would you like to continue (y/n)? ");
                    useryn = Console.ReadLine().ToLower();
                    if (useryn == "n")
                        repeat = false;
                }
            }
            Console.WriteLine("\nGoodbye!");
            Thread.Sleep(1500);   */
            completed[31] = true;   // This is what allows this excersise to be marked completed in the main menu
        }
    static void Exercise32(List<bool> completed)
        {
            completed[32] = true;
        }
        static void Exercise33(List<bool> completed)
        {
            completed[33] = true;
        }
        static void Exercise34(List<bool> completed)
        {
            completed[34] = true;
        }
        static void Exercise35(List<bool> completed)
        {
            completed[35] = true;
        }
        static void Exercise36(List<bool> completed)
        {
            completed[36] = true;
        }
        static void Exercise37(List<bool> completed)
        {
            completed[37] = true;
        }
        static void Exercise38(List<bool> completed)
        {
            completed[38] = true;
        }
        static void Exercise39(List<bool> completed)
        {
            completed[39] = true;
        }
        static void Exercise40(List<bool> completed)
        {
            completed[40] = true;
        }
        static void Exercise41(List<bool> completed)
        {
            completed[41] = true;
        }
        static void Exercise42(List<bool> completed)
        {
            completed[42] = true;
        }
        static void Exercise43(List<bool> completed)
        {
            completed[43] = true;
        }
        static void Exercise44(List<bool> completed)
        {
            completed[44] = true;
        }
        static void Exercise45(List<bool> completed)
        {
            completed[45] = true;
        }
        static void Exercise46(List<bool> completed)
        {
            completed[46] = true;
        }
        static void Exercise47(List<bool> completed)
        {
            completed[47] = true;
        }
        static void Exercise48(List<bool> completed)
        {
            completed[48] = true;
        }
        static void Exercise49(List<bool> completed)
        {
            completed[49] = true;
        }
        static void Exercise50(List<bool> completed)
        {
            completed[50] = true;
        }
        static void Exercise51(List<bool> completed)
        {
            completed[51] = true;
        }
        static void Exercise52(List<bool> completed)
        {
            completed[52] = true;
        }
        static void Exercise53(List<bool> completed)
        {
            completed[53] = true;
        }
        static void Exercise54(List<bool> completed)
        {
            completed[54] = true;
        }
        static void Exercise55(List<bool> completed)
        {
            completed[55] = true;
        }
        static void Exercise56(List<bool> completed)
        {
            completed[56] = true;
        }
        static void Exercise57(List<bool> completed)
        {
            completed[57] = true;
        }
        static void Exercise58(List<bool> completed)
        {
            completed[58] = true;
        }
        static void DisplayMenu(List<bool> completed) // DiplayMenu takes completed list and displays which exercises
        {                                                   // have been completed and which ones have not.
            Console.Clear();
            string check;
            string checkTwo;
            Console.WriteLine("\n\n                                                 Week 3 Exercises\n\n");
            Console.WriteLine("\t\t==================================================================================");
            for (int i = 0; i < 16; i++)
            {
                check = " ";
                checkTwo = " ";
                if (i < 1 || i > 14)
                    Console.WriteLine("\t\t||\t\t\t\t\t\t\t\t\t\t||");
                else
                {   
                    if (completed[i+30] == true)
                        check = "X";
                    if (completed[i+44] == true)
                        checkTwo = "X";
                    Console.WriteLine($"\t\t||\t\tExercise {i + 30} [{check}]\t\t\tExercise {i + 44}[{checkTwo}]\t\t\t||");
                }
            }
            Console.WriteLine("\t\t==================================================================================");
        }
        static void Main(string[] args) // Calls DisplayMenu and asks which exercise to view, calls methods and exits when user is done.
        {
            List<bool> completed = new List<bool>();             // Just set completed[i] = true when ever you have completed excercise i. 
            for (int i = 0; i < 30; i++) // unused excercises
                completed.Add(false);
            for (int i = 31; i < 60; i++) // instantiate this weeks excercises to incomplete
                completed.Add(false);

            bool morePractice = true;
            string choice;

            while (morePractice == true)
            {
                DisplayMenu(completed);
                Console.Write("\n\n\t\tIf you would like to see an exercise, please enter the number or 'n' to quit: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "31":
                        Console.Clear();
                        Exercise31(completed);
                        break;
                    case "32":
                        Console.Clear();
                        Exercise32(completed);
                        break;
                    case "33":
                        Console.Clear();
                        Exercise33(completed);
                        break;
                    case "34":
                        Console.Clear();
                        Exercise34(completed);
                        break;
                    case "35":
                        Console.Clear();
                        Exercise35(completed);
                        break;
                    case "36":
                        Console.Clear();
                        Exercise36(completed);
                        break;
                    case "37":
                        Console.Clear();
                        Exercise37(completed);
                        break;
                    case "38":
                        Console.Clear();
                        Exercise38(completed);
                        break;
                    case "39":
                        Console.Clear();
                        Exercise39(completed);
                        break;
                    case "40":
                        Console.Clear();
                        Exercise40(completed);
                        break;
                    case "41":
                        Console.Clear();
                        Exercise41(completed);
                        break;
                    case "42":
                        Console.Clear();
                        Exercise42(completed);
                        break;
                    case "43":
                        Console.Clear();
                        Exercise43(completed);
                        break;
                    case "44":
                        Console.Clear();
                        Exercise44(completed);
                        break;
                    case "45":
                        Console.Clear();
                        Exercise45(completed);
                        break;
                    case "46":
                        Console.Clear();
                        Exercise46(completed);
                        break;
                    case "47":
                        Console.Clear();
                        Exercise47(completed);
                        break;
                    case "48":
                        Console.Clear();
                        Exercise48(completed);
                        break;
                    case "49":
                        Console.Clear();
                        Exercise49(completed);
                        break;
                    case "50":
                        Console.Clear();
                        Exercise50(completed);
                        break;
                    case "51":
                        Console.Clear();
                        Exercise51(completed);
                        break;
                    case "52":
                        Console.Clear();
                        Exercise52(completed);
                        break;
                    case "53":
                        Console.Clear();
                        Exercise53(completed);
                        break;
                    case "54":
                        Console.Clear();
                        Exercise54(completed);
                        break;
                    case "55":
                        Console.Clear();
                        Exercise55(completed);
                        break;
                    case "56":
                        Console.Clear();
                        Exercise56(completed);
                        break;
                    case "57":
                        Console.Clear();
                        Exercise57(completed);
                        break;
                    case "58":
                        Console.Clear();
                        Exercise58(completed);
                        break;
                    case "n":
                        morePractice = false;
                        break;
                    default:
                        break;

                }
            }

        } 
    }
}
