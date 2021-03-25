using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Week_3_Excercises
{
    class Program
    {
        static void Exercise31(List<bool> completed)
        {
            /* int[] arr = { 2, 8, 0, 24, 51 };
             int userIndex;
             string useryn;
             bool repeat = true;

             while (repeat == true)
             {
                 useryn = "";
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
             Thread.Sleep(1500); */
        }
        static void Exercise32(List<bool> completed)
        {
            /* int[] arr = { 2, 8, 0, 24, 51 };
             string strUserInput;
             bool repeat = true;
             string useryn;
             bool found;
             int num;

             while (repeat == true)
             {
                 useryn = "";
                 found = false;
                 Console.Write("Enter a number: ");
                 strUserInput = Console.ReadLine();
                 for (int i = 0; i < arr.Length; i++)
                 {
                     if (Int32.TryParse(strUserInput, out num) && Convert.ToInt32(strUserInput) == arr[i])
                     {
                         found = true;
                         Console.WriteLine($"The value at {arr[i]} can be found at index {i}.");
                     }
                 }
                 if (found == false)
                     Console.WriteLine("That value cannot be found in the array.");
                 while (useryn != "y" && useryn != "n")
                 {
                     Console.Write("Would you like to continue (y/n)? ");
                     useryn = Console.ReadLine().ToLower();
                     if (useryn == "n")
                         repeat = false;
                 }
             }
             Console.WriteLine("\nGoodbye!");
             Thread.Sleep(1500); */
        }
        static void Exercise33(List<bool> completed)
        {

        }
        static void Exercise34(List<bool> completed)
        {

        }
        static void Exercise35(List<bool> completed)
        {

        }
        static void Exercise36(List<bool> completed)
        {

        }
        static void Exercise37(List<bool> completed)
        {

        }
        static void Exercise38(List<bool> completed)
        {

        }
        static void Exercise39(List<bool> completed)
        {

        }
        static void Exercise40(List<bool> completed)
        {

        }
        static void Exercise41(List<bool> completed)
        {

        }
        static void Exercise42(List<bool> completed)
        {

        }
        static void Exercise43(List<bool> completed)
        {

        }
        static void Exercise44(List<bool> completed)
        {

        }
        static void Exercise45(List<bool> completed)
        {

        }
        static void Exercise46(List<bool> completed)
        {

        }
        static void Exercise47(List<bool> completed)
        {

        }
        static void Exercise48(List<bool> completed)
        {

        }
        static void Exercise49(List<bool> completed)
        {

        }
        static void Exercise50(List<bool> completed)
        {

        }
        static void Exercise51(List<bool> completed)
        {

        }
        static void Exercise52(List<bool> completed)
        {

        }
        static void Exercise53(List<bool> completed)
        {

        }
        static void Exercise54(List<bool> completed)
        {

        }
        static void Exercise55(List<bool> completed)
        {

        }
        static void Exercise56(List<bool> completed)
        {

        }
        static void Exercise57(List<bool> completed)
        {

        }
        static void Exercise58(List<bool> completed)
        {

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
                    if (completed[i + 30] == true)
                        check = "X";
                    if (completed[i + 44] == true)
                        checkTwo = "X";
                    Console.WriteLine($"\t\t||\t\tExercise {i + 30} [{check}]\t\t\tExercise {i + 44}[{checkTwo}]\t\t\t||");
                }
            }
            Console.WriteLine("\t\t==================================================================================");
        }
        static void SaveTextFile(List<bool> completed)
        {
            TextWriter progressText = new StreamWriter("ProgressText.txt");

            foreach (bool x in completed)
                progressText.WriteLine(x);
            progressText.Close();

        }
        static void CompletedExercise(List<bool> completed, int exnum)
        {
            string userIn = "";

            Console.Clear();
            while (userIn != "y" && userIn != "n")
            {
                Console.Write("Would you like to save this exercise as completed (y/n)? ");
                userIn = Console.ReadLine().ToLower();
                if (userIn == "y")
                    completed[exnum] = true;
                else
                    completed[exnum] = false;
            }

        }
        static void Main(string[] args) // Calls DisplayMenu and asks which exercise to view, calls methods and exits when user is done.
        {
            List<bool> completed = new List<bool>();             // Just set completed[i] = true when ever you have completed excercise i.
            if (!File.Exists("ProgressText.txt"))
            {
                var textFile = File.Create("ProgressText.txt");
                textFile.Close();
            }


            for (int i = 0; i < 30; i++) // unused excercises
                completed.Add(false);
            for (int i = 31; i < 60; i++) // instantiate this weeks excercises to incomplete
                completed.Add(false);

            string[] lines = File.ReadAllLines("ProgressText.txt");

            if (File.Exists("ProgressText.txt"))
            {
                int x = 0;
                foreach (string line in lines)
                {
                    completed[x] = Convert.ToBoolean(line);
                    x++;
                }
            }



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
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "32":
                        Console.Clear();
                        Exercise32(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "33":
                        Console.Clear();
                        Exercise33(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "34":
                        Console.Clear();
                        Exercise34(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "35":
                        Console.Clear();
                        Exercise35(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "36":
                        Console.Clear();
                        Exercise36(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "37":
                        Console.Clear();
                        Exercise37(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "38":
                        Console.Clear();
                        Exercise38(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "39":
                        Console.Clear();
                        Exercise39(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "40":
                        Console.Clear();
                        Exercise40(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "41":
                        Console.Clear();
                        Exercise41(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "42":
                        Console.Clear();
                        Exercise42(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "43":
                        Console.Clear();
                        Exercise43(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "44":
                        Console.Clear();
                        Exercise44(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "45":
                        Console.Clear();
                        Exercise45(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "46":
                        Console.Clear();
                        Exercise46(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "47":
                        Console.Clear();
                        Exercise47(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "48":
                        Console.Clear();
                        Exercise48(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "49":
                        Console.Clear();
                        Exercise49(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "50":
                        Console.Clear();
                        Exercise50(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "51":
                        Console.Clear();
                        Exercise51(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "52":
                        Console.Clear();
                        Exercise52(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "53":
                        Console.Clear();
                        Exercise53(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "54":
                        Console.Clear();
                        Exercise54(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "55":
                        Console.Clear();
                        Exercise55(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "56":
                        Console.Clear();
                        Exercise56(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "57":
                        Console.Clear();
                        Exercise57(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "58":
                        Console.Clear();
                        Exercise58(completed);
                        CompletedExercise(completed, Convert.ToInt32(choice));
                        break;
                    case "n":
                        morePractice = false;
                        SaveTextFile(completed);
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
