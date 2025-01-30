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
            // decalre number varibale
            int number = 0;
            //decalre sum varibale
            int sum = 0;
            //prints promt asking user to input a number
            Console.WriteLine(" input a number ");
            //collects and convert user input
            number = Convert.ToInt32(Console.ReadLine());

            //users loop to find all odd numbers in user input
          //  for(int i =0;i<number; i++)
          //  {
          //      if(i % 2 == 1)
          //      {
          //          sum = sum + i;
          //      }
          //  }
          // //prints final sum of odd numbers
          //  Console.WriteLine(sum);

            //uses loop to find all odd numbers in user input
            for(int i =1; i < number; i=i+2)
            {
                sum = sum + i;
            }
            //prints final sum of odd numbers
            Console.WriteLine(sum);


        }
    }
}
