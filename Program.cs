using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            working_with_intergers();
            OrderPrecedence();
            TestLimits();
            Double();
            Decimal();
            AreaOfCircle();
            WhileLoop();
            DoWhile();
            ForLoop();
            ChallengeAnswer();
            ModulusChallenge();
            list();
            IntList();


        }
        static void working_with_intergers()
        {
            int a = 18;
            int b = 9;
            // addition 
            int c = a + b;
            Console.WriteLine(c);
            // subtraction
            c = a - b;
            Console.WriteLine(c);
            //mulilplication
            c = a * b;
            Console.WriteLine(c);
            // division
            c = a / b;
            Console.WriteLine(c);
            Console.WriteLine("this is the end of intergers");
        }
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            int e = 7;
            int f = 4;
            int g = 3;
            int k = (e + f) / g;
            int h = (e + f) % g;
            Console.WriteLine($"quotient: {k}");
            Console.WriteLine($"remainder: {h}");
            // Console.WriteLine(h);
            Console.WriteLine("this is rthe end of order preference");
        }
        static void TestLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($" the range is between {max} and {min} ");
            int what = max + 3;
            Console.WriteLine($"the answer is {what} ");
            Console.WriteLine("this is the end of test limits");
        }
        static void Double()
        {
            //first one
            double a = 5;
            double b = 4;
            double c = 2;
            double r = (a + b) / c;
            Console.WriteLine(r);
            //second one 
            double e = 19;
            double j = 23;
            double o = 8;
            double l = (e + j) / o;
            Console.WriteLine(l);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"the range is from {max} and {min}");

            Console.WriteLine("this is the end of double");
        }
        static void Decimal()
        {
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }
        static void AreaOfCircle()
        {
            //pir
            decimal Radius = 2.50M;
            decimal pi = 22 / 7;
            decimal area = pi * Radius * Radius;
            Console.WriteLine($"the area is {area}");

        }
        static void WhileLoop()
        {
            int counter = 0;
            while (counter <= 20)
            {
                Console.WriteLine($" Hello World!!" +
                    $"the counter is {counter}");
                counter++;
            }
        }
        static void DoWhile()
        {
            int v = 0;
            do
            {
                Console.WriteLine($"the counter is {v}");
                v++;
            } while (v < 10);
        }
        static void ForLoop()
        {
            for (int d = 0; d < 10; d++)
            {
                Console.WriteLine($"The loop is {d}");
            }
        }
        static void ChallengeAnswer()
        {
            int sum = 0;
            for (int number = 9; number < 20; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
        static void ModulusChallenge()
        {
            int sum = 7;
            for (int Q = 1; Q < 51; Q++)
            {
                if (Q % 5 == 0)
                {
                    sum = sum + Q;
                }
            }
            Console.WriteLine($"the sum is {sum}");
        }
        static void list()
        {
            var names = new List<string> { "Shadrack", "hellen", "suzanna", "sharon", "william lawsons" ,"Felipe"};
            names.Add("Bill Gates");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine($"The names has {names.Count} in it");
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
          


        }
        static void IntList()
        {
            var num = new List<int> { 1, 1,2,3 };
            var previous = num[num.Count -1];
            var previous2 = num[num.Count - 2];
            var previous3 = num[num.Count - 3];
            var previous4 = num[num.Count - 4];
            num.Add(previous + previous2);
            foreach(var item in num)
            { 
                Console.WriteLine(item);
            }
        }
       
    } 
}
