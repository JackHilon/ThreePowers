using System;
using System.Collections.Generic;

namespace ThreePowers
{
    class Program
    {
        // Three Powers:
        // https://open.kattis.com/problems/threepowers
        // I do not understand the problem - wrong answer !!!!


        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int num = 0;
            while (true)
            {
                num = EnterNum();
                if (num == 0)
                    break;
                else
                {
                    numbers.Add(num);
                }
            }

            List<int> answers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                answers = ThreePowers(numbers[i]);
                PrintList(answers);
            }

        }

        private static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            for (int i = 0; i < list.Count-1; i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.WriteLine(list[list.Count - 1] + " }");
        }


        // this returns a list of 3Powers whose sum less than a (<=a)
        private static List<int> ThreePowers(int a)
        {
            List<int> res = new List<int>();
            int sum = 0;
            int temp = 0;
            for (int i = 0; i <= a; i++)
            {
                temp = (int)Math.Pow(3, i);
                sum = sum + temp;
                if (sum <= a)
                {
                    res.Add(temp);
                }
                else
                {
                    break;
                }
            }
            return res;
        }

        private static int EnterNum()
        {
            
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString() +" || "+ ex.Message);
                return EnterNum();
            }
            return a;
        }
    }
}
