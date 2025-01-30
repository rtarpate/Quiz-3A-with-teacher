using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_3A_with_teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            int sum = 0;

            Console.WriteLine(" input a number ");

            number = Convert.ToInt32(Console.ReadLine());

          //  for(int i =0;i<number; i++)
          //  {
          //      if(i % 2 == 1)
          //      {
          //          sum = sum + i;
          //      }
          //  }
          //
          //  Console.WriteLine(sum);

            for(int i =1; i < number; i=i+2)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);


        }
    }
}
