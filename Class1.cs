using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    class Class1
    {
        public static void Myprogram()
        {
            MyClass x;
            int[] nums = new int[100];
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {

                int mult3 = i * 3;
                nums[i]= mult3;
                //sum = sum + nums[i];
                sum += nums[i];
                Console.WriteLine(nums[i]);

            }
            double average = sum / nums.Length;
            Console.WriteLine(average);
            //Console.WriteLine("Sum is :" + sum);
        }
    }
}
