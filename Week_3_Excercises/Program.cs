using System;
using System.Collections.Generic;
using System.Threading;

namespace Week_3_Excercises
{
    class Program
    {
        static void Excercise31(List<bool> completed)
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
    static void Excercise32(List<bool> completed)
        {
            completed[32] = true;
        }
        static void Excercise33(List<bool> completed)
        {
            completed[33] = true;
        }
        static void Excercise34(List<bool> completed)
        {
            completed[34] = true;
        }
        static void Excercise35(List<bool> completed)
        {
            completed[35] = true;
        }
        static void Excercise36(List<bool> completed)
        {
            completed[36] = true;
        }
        static void Excercise37(List<bool> completed)
        {
            completed[37] = true;
        }
        static void Excercise38(List<bool> completed)
        {
            completed[38] = true;
        }
        static void Excercise39(List<bool> completed)
        {
            completed[39] = true;
        }
        static void Excercise40(List<bool> completed)
        {
            completed[40] = true;
        }
        static void Excercise41(List<bool> completed)
        {
            completed[41] = true;
        }
        static void Excercise42(List<bool> completed)
        {
            completed[42] = true;
        }
        static void Excercise43(List<bool> completed)
        {
            completed[43] = true;
        }
        static void Excercise44(List<bool> completed)
        {
            completed[44] = true;
        }
        static void Excercise45(List<bool> completed)
        {
            completed[45] = true;
        }
        static void Excercise46(List<bool> completed)
        {
            completed[46] = true;
        }
        static void Excercise47(List<bool> completed)
        {
            completed[47] = true;
        }
        static void Excercise48(List<bool> completed)
        {
            completed[48] = true;
        }
        static void Excercise49(List<bool> completed)
        {
            completed[49] = true;
        }
        static void Excercise50(List<bool> completed)
        {
            completed[50] = true;
        }
        static void Excercise51(List<bool> completed)
        {
            completed[51] = true;
        }
        static void Excercise52(List<bool> completed)
        {
            completed[52] = true;
        }
        static void Excercise53(List<bool> completed)
        {
            completed[53] = true;
        }
        static void Excercise54(List<bool> completed)
        {
            completed[54] = true;
        }
        static void Excercise55(List<bool> completed)
        {
            completed[55] = true;
        }
        static void Excercise56(List<bool> completed)
        {
            completed[56] = true;
        }
        static void Excercise57(List<bool> completed)
        {
            completed[57] = true;
        }
        static void Excercise58(List<bool> completed)
        {
            completed[58] = true;
        }
        static void DisplayMenu(List<bool> completed) // DiplayMenu takes completed list and displays which excercises
        {                                                   // have been completed and which ones have not.
            Console.Clear();
            string check;
            string checkTwo;
            Console.WriteLine("\n\n                                                 Week 3 Excercises\n\n");
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
                    Console.WriteLine($"\t\t||\t\tExcercize {i + 30} [{check}]\t\t\tExcercize {i + 44}[{checkTwo}]\t\t||");
                }
            }
            Console.WriteLine("\t\t==================================================================================");
        }
        static void Main(string[] args)
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
                Console.Write("\n\n\t\tIf you would like to see an excercise, please enter the number or 'n' to quit: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "31":
                        Console.Clear();
                        Excercise31(completed);
                        break;
                    case "32":
                        Console.Clear();
                        Excercise32(completed);
                        break;
                    case "33":
                        Console.Clear();
                        Excercise33(completed);
                        break;
                    case "34":
                        Console.Clear();
                        Excercise34(completed);
                        break;
                    case "35":
                        Console.Clear();
                        Excercise35(completed);
                        break;
                    case "36":
                        Console.Clear();
                        Excercise36(completed);
                        break;
                    case "37":
                        Console.Clear();
                        Excercise37(completed);
                        break;
                    case "38":
                        Console.Clear();
                        Excercise38(completed);
                        break;
                    case "39":
                        Console.Clear();
                        Excercise39(completed);
                        break;
                    case "40":
                        Console.Clear();
                        Excercise40(completed);
                        break;
                    case "41":
                        Console.Clear();
                        Excercise41(completed);
                        break;
                    case "42":
                        Console.Clear();
                        Excercise42(completed);
                        break;
                    case "43":
                        Console.Clear();
                        Excercise43(completed);
                        break;
                    case "44":
                        Console.Clear();
                        Excercise44(completed);
                        break;
                    case "45":
                        Console.Clear();
                        Excercise45(completed);
                        break;
                    case "46":
                        Console.Clear();
                        Excercise46(completed);
                        break;
                    case "47":
                        Console.Clear();
                        Excercise47(completed);
                        break;
                    case "48":
                        Console.Clear();
                        Excercise48(completed);
                        break;
                    case "49":
                        Console.Clear();
                        Excercise49(completed);
                        break;
                    case "50":
                        Console.Clear();
                        Excercise50(completed);
                        break;
                    case "51":
                        Console.Clear();
                        Excercise51(completed);
                        break;
                    case "52":
                        Console.Clear();
                        Excercise52(completed);
                        break;
                    case "53":
                        Console.Clear();
                        Excercise53(completed);
                        break;
                    case "54":
                        Console.Clear();
                        Excercise54(completed);
                        break;
                    case "55":
                        Console.Clear();
                        Excercise55(completed);
                        break;
                    case "56":
                        Console.Clear();
                        Excercise56(completed);
                        break;
                    case "57":
                        Console.Clear();
                        Excercise57(completed);
                        break;
                    case "58":
                        Console.Clear();
                        Excercise58(completed);
                        break;
                    case "n":
                        morePractice = false;
                        break;
                    default:
                        break;

                }
            }

        } // Calls DisplayMenu and asks which excersise to view, calls methods and exits when user is done.
    }
}
