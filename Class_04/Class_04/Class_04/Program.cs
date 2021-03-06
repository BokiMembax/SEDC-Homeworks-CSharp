﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_04
{
    class Program
    {
        static void SumOfEvens()
        {
            int[] niza = new int[6];
            int sum = 0;           
            for (int i = 0; i < niza.Length; i++)
            {
                Console.WriteLine("Enter integer no " + (i + 1));
                string element = Console.ReadLine();
                int elementParsed = int.Parse(element);
                niza[i] = elementParsed;
                if (niza[i] % 2 == 0)
                {
                    sum += niza[i];
                }
                else sum += 0;
            }
            Console.WriteLine("The result is: " + sum);
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        static void StudentGroup()
        {
            string[] studentsG1 = new string[] { "Chiellini", "Bonucci", "Barzagli", "De Sciglio", "Rugani", "Matuidi" };
            string[] studentsG2 = new string[] { "Khedira", "Dybala", "Alex Sandro", "Ronaldo", "Douglas Costa", "Cuadrado" };
            Console.WriteLine("Enter a group: ");
            string gr = Console.ReadLine();
            if (gr == "1")
            {
                Console.WriteLine("The students in G1 are: ");
                foreach (var student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if(gr == "2")
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (var student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            } 
            else Console.WriteLine("No such group.");
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SumOfEvens();
            StudentGroup();
        }
    }
}
