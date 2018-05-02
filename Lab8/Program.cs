using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (true)
            //{
            string[] Names = { "Abby", "Bobby", "Charity", "Debby", "Emma", "Falicia", "Gabriel", "Heather", "Inga", "Jazel", "Kammy", "Luise", "Margeret", "Naomi", "Oprah", "Penelope", "Quan", "Rebecca", "Shay", "Tammy" };
            string[] hometown = { "Ann arbor", "Bardoux", "Cincinatti", "Detroit", "Esexville", "Farwell", "Gaylord", "Hamilton", "Ingum", "Jarusalem", "Kansas City", "Langdon", "Monroe", "Nashville", "Omar", "Park City", "Quebec City", "Reno", "Saginaw", "Tempe" };
            string[] fFood = { "Apple", "Banana", "Cherry", "Durian", "Elderberry", "Focaccia", "Grape", "Hummus", "Ice cream", "Jack fruit", "Kuarma", "Lemonade", "Mango", "Nori", "Orzo", "Pumpkin Pie", "Quinoa", "Radish", "Spaghetti", "Tuna" };

            Console.WriteLine();
            Console.WriteLine("Hello, Welcome to your newschool.");
            Console.WriteLine();
            Console.WriteLine("Your new here, you should get to meet your classmates. there are 20 of them!");
            Console.WriteLine("Which student would you like to know more about?");
            int counter = 0;
            foreach (string StudentNumber in Names)
            {
                counter++;
                Console.WriteLine($"{counter}. {StudentNumber}");
            }
            while (true)
            {
                while (true)
                {
                    Console.Write("Please choose a student ID number (1-20): ");


                    string input = Console.ReadLine();
                    int index;
                    bool Success = int.TryParse(input, out index);
                    index--;


                    if (index >= 0 && index < Names.Length)
                    {
                        if (Success)
                        {
                            while (true)
                            {
                                Console.WriteLine($"What would you like to know about {Names[index]}?");
                                while (true)
                                {
                                    Console.WriteLine("If you would like to know where she is from type \"Hometown\"");
                                    Console.WriteLine("If you would like to know what her favorite food is type \"Favorite Food\"");
                                    string choice = Console.ReadLine().ToLower();
                                    if (choice == "hometown")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(hometown[index]);
                                        return;
                                    }
                                    else if (choice == "favorite food")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(fFood[index]);
                                        return;
                                    }

                                    else
                                    {
                                        Console.WriteLine("I'm not sure what you're asking nor do we have that type of information.");
                                    }
                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine("There is no student by that label");
                        }

                    }

                    else
                    {
                        Console.WriteLine("We don't have that many students");
                        continue;
                    }


                    string again = Console.ReadLine().ToUpper();
                    if (again == "YES")
                    {
                        continue;
                    }
                    else if (again == "NO")
                    {
                        return;
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}


