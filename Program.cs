using System;
namespace Project
{
    class Program
    {
    static void Main(string[]args)
        {
            int N=Convert.ToInt32(Console.ReadLine());
            int result= 1;
            for (int g= 1; g<=N ;g++)
         {
             result = result*g;   
         }
                Console.WriteLine(result);
        }
    }
}
