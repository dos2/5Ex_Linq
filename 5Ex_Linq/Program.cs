using System;
using System.Collections;
using System.Linq;

namespace _5Ex_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE1
            int[] numbers = {2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            int[] even = (from n in numbers
                                 where (n % 2) ==0
                                 select n).ToArray(); 
            foreach(int num in even)
            {
                Console.WriteLine(num);
            }

            //FASE2
            int maxNum=even.Max();
            int minNum=even.Min();
            double average=even.Average();
            Console.WriteLine($"Màxim: {maxNum}\nMínim: {minNum}\nMitjana: {average}");

            //FASE3
            int[] aboveFive = (from n in numbers
                              where n > 5
                              select n).ToArray();
            int[] belowFive = (from n in numbers
                              where n < 5
                              select n).ToArray();
            Console.WriteLine("Aprovats: ");
            foreach(int a in aboveFive)
            {
                Console.Write(a +",");
            }
            Console.WriteLine("\nSuspesos: ");
            foreach(int b in belowFive)
            {
                Console.Write(b + ",");
            }
            Console.WriteLine();
            //FASE4
            string[] arrayNames= {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            string[] startingO = (from n in arrayNames
                                  where n.StartsWith("O")
                                  select n).ToArray();
            string[] sixLetters = (from n in arrayNames
                                   where n.Length>6
                                   select n).ToArray();
            string[] arrangedNames=(from n in arrayNames
                                    orderby n descending
                                    select n).ToArray();
            Console.Write("Noms iniciats amb O: ");
            foreach (string n in startingO) {Console.Write(n + ",");}
            Console.WriteLine();
            Console.Write("Noms amb més de 6 lletres: ");
            foreach(string n in sixLetters) { Console.Write(n + ","); }
            Console.WriteLine();
            Console.Write("Noms ordenats en ordre descendent: ");
            foreach(string n in arrangedNames) { Console.Write(n + ","); }
        }
    }
}
