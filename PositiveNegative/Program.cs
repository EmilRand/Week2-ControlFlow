using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //programm palub kasutajal sisesta nubrirt -10 kuni 10
            //programm kontrollib seda numbrit
            //kui nr on positiivne, konsool kuvab positive
            //kui nr on negatiivne, konsool kuvab negative
            //kui nr on 0, siis konsool kuvab null

            Console.WriteLine("valige number -10 kuni 10");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)

            {
                Console.WriteLine("su number on positiivne");
            }
            else if (num < 0)
            {
                Console.WriteLine("su number on negatiivne");
            }
            else
            {
                Console.WriteLine("Teie valitud number on null");
            }
            Console.ReadLine();


        }
       
        
    }
}
