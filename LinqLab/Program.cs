using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //num functions
            //1
            var numMin = nums.Min();
            Console.WriteLine(numMin);
            //2
            var numMax = nums.Max();
            Console.WriteLine(numMax);
            //3
            var numLess = nums.Where(n => n < 10000).ToList().Max();
            Console.WriteLine(numLess);
            //4
            var numBet = nums.Where(n => (n > 9) && (n < 101)).ToList();
            foreach(var n in numBet)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
            //5
            var numBigBet = nums.Where(n => (n >= 100000) && (n <= 999999)).ToList();
            foreach (var n in numBigBet)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
            //6
            var numEven = nums.Where(n => n % 2 == 0).Count();
            Console.WriteLine(numEven);

            //Student functions
            //1
            var studOver = students.Where(s => s.Age >= 21).ToList();
            foreach(Student s in studOver)
            {
                Console.Write(s.Name + " ");
            }
            
            Console.WriteLine();
            //2
            var studMax = students.Max(n => n.Age);

            foreach(Student s in students)
            {
                if(s.Age == studMax)
                {
                    Console.WriteLine(s.Name);
                }
            }
            //3
            var studMin = students.Min(n => n.Age);

            foreach (Student s in students)
            {
                if (s.Age == studMin)
                {
                    Console.WriteLine(s.Name);
                }
            }
            //4
            var studUnder = students.Where(n => n.Age < 25).ToList().Max(n => n.Age);

            foreach (Student s in students)
            {
                if (s.Age == studUnder)
                {
                    Console.WriteLine(s.Name);
                }
            }

            //5
            var studEven = students.Where(n => (n.Age > 21) && (n.Age % 2 == 0)).ToList();

           foreach(Student s in studEven)
            {
                Console.Write(s.Name);
            }
            Console.WriteLine();
            //6
            var teens = students.Where(s => (s.Age > 12) && (s.Age < 20)).ToList();
            foreach(Student s in teens)
            {
                Console.Write(s.Name + " ");
            }
            Console.WriteLine();
            //7
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            var studVowels = students.Where(s => s.Name.IndexOfAny(vowels) == 0).ToList();
            foreach(Student s in studVowels)
            {
                Console.Write(s.Name);
            }
        }
    }
}
