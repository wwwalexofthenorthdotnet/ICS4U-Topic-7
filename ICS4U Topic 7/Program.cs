using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICS4U_Topic_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            bool finish = false;

            int menuChoice = 0;

            while (!finish)
            {
                Console.Clear();
                Console.WriteLine("Topic 7 - Lists and Arrays : \n 0. Quit \n 1. Integer Lists \n 2. String Lists");

                if (Int32.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Thank you for using my program.");
                            finish = true;
                            break;
                        case 1:
                            Console.Clear();
                            IntLists();
                            break;
                        case 2:
                            Console.Clear();
                            StringLists();
                            break;
                    }
                }
            }
        }


        public static void IntLists()
        {
            List<int> randNum = new List<int>();
            

            Random generator = new Random();

            int menuChoice = 0;

            bool finish = false;

            int removeNum = 0;
            int addNum = 0;
            int countNum = 0;
            int countedNum = 0;
            int maxNum = 0;
            int minNum = 0;
            int largestIndex = 0, largestPosition = 0;




            for (int i = 0; i < 25; i++)
            {
                randNum.Add(generator.Next(10, 21));
            }

            while (!finish)
            {

                Console.WriteLine("Here are your random numbers: ");
                Console.Write("[ ");

                for (int i = 0; i < randNum.Count; i++)
                {
                    Console.Write(randNum[i]);

                    if (i != randNum.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" ]");

                Console.WriteLine();
                Console.WriteLine("Integer Lists : \n 1. Sort List \n 2. New List \n 3. Remove Num \n 4. Add Value \n 5. Count Number of Occurances \n 6. Largest Value \n 7. Smallest Value \n 8. Sum & Average \n 0. Quit");

                Console.Write("Input Value : ");
                Int32.TryParse(Console.ReadLine(), out menuChoice);

                Console.Clear();

                switch (menuChoice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Back to main menu.");
                        finish = true;
                        break;
                    case 1:
                        randNum.Sort();

                        Console.WriteLine("Here is your sorted list!");

                        for (int i = 0; i < randNum.Count; i++)
                        {
                            Console.Write(randNum[i]);

                            if (i != randNum.Count - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        Next();

                        break;
                    case 2:

                        Console.WriteLine("Here is your new random list!");

                        randNum.Clear();

                        for (int i = 0; i < 25; i++)
                        {
                            randNum.Add(generator.Next(10, 21));
                        }

                        for (int i = 0; i < randNum.Count; i++)
                        {
                            Console.Write(randNum[i]);

                            if (i != randNum.Count - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        Next();

                        break; 
                    case 3:

                        Console.WriteLine("Which Number would you like to REMOVE");

                        if (Int32.TryParse(Console.ReadLine(), out removeNum))
                        {
                            for (int i = 0; i <= randNum.Count; i++)
                            { 
                                randNum.Remove(removeNum);
                            }
                        }

                        Console.Clear();

                        Console.WriteLine($"Here is list with {removeNum} removed.");

                        for (int i = 0; i < randNum.Count; i++)
                        {
                            Console.Write(randNum[i]);

                            if (i != randNum.Count - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        Next();

                        


                        break;
                    case 4:
                        Console.WriteLine("Which Number would you like to ADD");

                        if (Int32.TryParse(Console.ReadLine(), out addNum))
                        {
                            randNum.Add(addNum);
                        }

                        Console.WriteLine($"Here is list with {addNum} added.");

                        for (int i = 0; i < randNum.Count; i++)
                        {
                            Console.Write(randNum[i]);

                            if (i != randNum.Count - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        Next();

                        break;
                    case 5:
                        Console.WriteLine("Which Number would you like to COUNT");
                        if (Int32.TryParse(Console.ReadLine(), out countNum))
                        {
                            for (int i = 0; i < randNum.Count; i++)
                            {
                                if (randNum[i] == countNum)
                                {
                                    countedNum++;
                                }
                            }

                            Console.WriteLine($"There are {countedNum} instances of {countNum}.");

                            countNum = 0;
                            countedNum = 0; 


                            Next();
                        }
                        break;
                    case 6:
                        maxNum = randNum.Max();

                        Console.WriteLine($"The largest value in the list is {maxNum}.");

                        maxNum = 0;

                        Next();

                        break;
                    case 7:
                        minNum = randNum.Min();

                        Console.WriteLine($"The largest value in the list is {minNum}.");

                        minNum = 0;

                        Next();

                        break;
                    case 8:
                        Console.WriteLine($"The average of the list is {Math.Round(randNum.Average(), 2)} and the sum is {randNum.Sum()}.");
                        Next();

                        break;
                    
                }

            }

            

        }

        public static void StringLists()
        {
            List<string> vegetables = new List<string>() { "carrots", "beet", "celery", "radish", "cabbage" };

            int menuChoice = 0, removeIndex = 0, searchIndex;

            string removeValue = "", addValue = "", searchValue = "";

            bool finish = false;

            while (!finish)
            {
                Console.Clear();
                Console.WriteLine("Vegetables : ");
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {vegetables[i]}");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("String Lists : \n 1. Remove Vegetable (by index) \n 2. Remove Vegetable (by name) \n 3. Search for Vegetable \n 4. Add a Vegetable \n 5. Sort List \n 6. Clear List \n 0. Quit \n");

                if (Int32.TryParse(Console.ReadLine(), out menuChoice))
                {
                    
                    switch (menuChoice)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Back to main menu.");
                            Next();
                            finish = true;
                            break;
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Vegetables : ");
                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} - {vegetables[i]}");
                                Console.WriteLine();
                            }

                            Console.Write("Input the index of the Vegetable you would like to remove : ");
                            if (Int32.TryParse(Console.ReadLine(), out removeIndex))
                            {
                                if (removeIndex > 0 && removeIndex + 1 <= vegetables.Count + 1)
                                Console.WriteLine($"{vegetables[removeIndex - 1]} removed.");

                                vegetables.RemoveAt(removeIndex - 1);


                            }
                            else
                            {
                                Console.WriteLine("Must be smaller than the list size.");
                            }

                            Next();

                            removeIndex = 0;

                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Input the name of the vegetable you would like to remove : ");

                            
                            removeValue = Console.ReadLine();

                            if (addValue != "")
                            {

                                vegetables.Remove(removeValue);

                                Console.Write($"Removed {removeValue.Trim().ToLower()}.");
                            }

                            Next();
                            
                            
                            break;
                        case 3:
                            Console.Write("Input what vegetable you would like to search for : ");
                            searchValue = Console.ReadLine();

                            if (searchValue == "")
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Input");

                            }
                            else
                            {

                                searchIndex = vegetables.FindIndex(n => n.Equals(searchValue.ToLower().Trim()));
                                Console.WriteLine($"Your vegetable was found at index {searchIndex + 1}.");

                            }
                            Next();
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Input the name of the vegetable you would like to add : ");



                            addValue = Console.ReadLine();

                            if (addValue != "")
                            {

                                vegetables.Add(addValue);

                                Console.Write($"Added {addValue.Trim().ToLower()}.");
                            }
                            Next();

                            break;
                        case 5:
                            Console.Clear();
                            vegetables.Sort();

                            Console.Write("List Sorted");


                            Next();
                            break;
                        case 6:
                            Console.Clear();
                            vegetables.Clear();

                            Console.Write("List cleared");

                            Next();


                            break;
                    }
                }
            }
        }



        public static void Next()
        {
            Console.WriteLine();
            Console.WriteLine("press ANY key to continue.");
            Console.ReadKey();
            Console.Clear();
        }




    }
}
