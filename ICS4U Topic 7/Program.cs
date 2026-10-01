using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
                Console.WriteLine("Menu : \n 1. Sort List \n 2. New List \n 3. Remove Num \n 4. Add Value \n 5. Count Number of Occurances \n 6. Largest Value \n 7. Smallest Value \n 0. Quit");

                Console.Write("Input Value : ");
                Int32.TryParse(Console.ReadLine(), out menuChoice);

                Console.Clear();

                switch (menuChoice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Thank you for using my program.");
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
                }

            }

            

        }



        public static void Next()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press ANY key to continue.");
            Console.ReadKey();
            Console.Clear();
        }




    }
}
