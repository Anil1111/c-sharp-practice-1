﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] nums = new int[1000];

            for (int i = 0; i < 1000; i++)
                nums[i] = random.Next(1, 1000);

            //for (int index = 1; index < nums.Length; index++)
            //{
            //    int num;
            //    bool check = true;
            //    do
            //    {
            //        num = random.Next(1, 1000);
            //        if (!nums.Contains(num))
            //        {
            //            nums[index] = num;
            //            check = false;
            //        }

            //    }
            //    while (check);
            //}

            for (int i = 0; i < Math.Ceiling(Convert.ToDouble(nums.Length) / 10); i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{nums[i * 10 + j],3}  ");
                }
                Console.WriteLine('\n');
            }

            Console.Write("Press any key to order...");
            Console.ReadKey();
            Console.Clear();

            bool exit;

            do
            {
                exit = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        exit = true;
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
            }
            while (exit);

            for (int i = 0; i < Math.Ceiling(Convert.ToDouble(nums.Length) / 10); i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{nums[i * 10 + j],3}  ");
                }
                Console.WriteLine('\n');
            }

            Console.ReadKey();
        }
    }
}
