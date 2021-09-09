using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust
            Console.WriteLine("Mis aastal olete te sündinud?");
            int YearOfBirth = Convert.ToInt32 (Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            Console.WriteLine("Te olete " + Age);


        
        }
    }
}
