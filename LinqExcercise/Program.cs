using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bilar = { "Volvo", "BMW", "Audi", "Skoda", "Toyota", "Ford", "Mercedes", "Seat", "Honda", "Volkswagen", "Opel", "Mazda", "Suzuki" };
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics ", " Genesis ", " INXS ", " Midnight Oil ", " Kent ", " Madness ", " Manic Street Preachers ", " The Offspring ", " Pink Floyd ", " Rammstein ", " Red Hot Chili Peppers ", "Deep Purple", "U2" };
            List<int> numbers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };
            string[] nameList = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" };
            int[] list = { 1, 3, 5, 7 };
            string fullText = "Flying snipes seek whila on soft tufts";

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(" 1. CARS");
                Console.WriteLine(" 2. BAND");
                Console.WriteLine(" 3. FEATURES");
                Console.WriteLine(" 4. Order by");
                Console.WriteLine(" 5. NEW LIST");
                Console.WriteLine(" 6. VOICES");
                Console.WriteLine(" 0. EXIT");
                Console.WriteLine(" Enter a number: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Bring the car: ");
                            Console.WriteLine(" 2. Bring out all cars whose names start with ");
                            Console.WriteLine(" 3. Bring out all cars whose names contain the letters ");
                            Console.WriteLine(" 4. Bring out all cars that start with or ends with ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var car = Console.ReadLine().ToString();
                                    car = bilar.FirstOrDefault(c => c.Equals(car));
                                    Console.WriteLine(car);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    var name = Console.ReadLine();
                                    var names = bilar.Where(c => c.StartsWith(name));
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }                
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    name = Console.ReadLine();
                                    names = bilar.Where(c => c.Contains(name));
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    name = Console.ReadLine();
                                    names = bilar.Where(c => c.StartsWith(name) || c.EndsWith(name));
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }

                        break;
                    case 2:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Bring out the band that has the longest band name: ");
                            Console.WriteLine(" 2. Bring out the band with the shortest band name ");
                            Console.WriteLine(" 3. Find a number of how many bands start with the letter ");
                            Console.WriteLine(" 4. Make a list of all bands sorted alphabetically. Only show bands that have a band name longer than 6 letters ");
                            Console.WriteLine(" 5. Create a list that is sorted by the length of the band names. The band with the shortest name should end up first in the list and the one with the longest name should end up last ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var band = bands.OrderByDescending(c => c.Length).FirstOrDefault();
                                    Console.WriteLine(band);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    band = bands.OrderBy(c => c.Length).FirstOrDefault();
                                    Console.WriteLine(band);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    var name = Console.ReadLine();
                                    var bander = bands.Where(c => c.StartsWith(name));                                   
                                    Console.WriteLine(bander.Count());                                    
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    var names = bands.Where(c => c.Length > 6).OrderBy(c => c);
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    names = bands.OrderBy(c => c.Length);
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 3:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Retrieve the mean of all numbers without looping through the list. ");
                            Console.WriteLine(" 2. Bring out the largest of all numbers without looping through the list. ");
                            Console.WriteLine(" 3. Bring up the least of all numbers without looping through the list. ");
                            Console.WriteLine(" 4. Calculate the sum of all numbers. ");
                            Console.WriteLine(" 5. Generate all even numbers without looping through the list ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var num = numbers.Average();
                                    Console.WriteLine(num);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    num = numbers.Max();
                                    Console.WriteLine(num);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    num = numbers.Min();
                                    Console.WriteLine(num);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    num = numbers.Sum();
                                    Console.WriteLine(num);
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    var nums = numbers.Where(number => number % 2 == 0);
                                    foreach (var item in nums)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 4:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Sort by last name without using any loop ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var names = nameList.OrderBy(namn => namn.Substring(namn.IndexOf(' ')));                                    
                                    foreach (var item in names)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;                                
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 5:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Create a new list from this array where all values ​​are increased by 2, ie the new list becomes 3,5,7,9 ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    var newList = list.Select(num => num + 2).ToList();
                                    foreach (var item in newList)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 6:
                        while (choice != 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. Create a list of all the vowels in the sentence ");
                            Console.WriteLine(" 0. Back ");

                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    char[] vowels = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
                                    var listan = fullText.ToLower().Where( c=> vowels.Contains(c) ).ToList();   
                                    foreach (var item in listan)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        exit = true;
                        break;                        
                    default:
                        break;
                }
            }
        }
    }
}
