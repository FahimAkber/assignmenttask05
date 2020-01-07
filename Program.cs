using System;

namespace AssignmentTask05
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue, result;
            Console.WriteLine("Enter 1st Value: ");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value: ");
            secondValue = Convert.ToInt32(Console.ReadLine());

            if(firstValue != 0 && secondValue != 0){
                result = firstValue / secondValue;
                Console.WriteLine("your result is : "+result);
            }
        }
    }
}
