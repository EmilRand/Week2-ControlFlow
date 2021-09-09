using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada (tingimuseks 18 aastat)

            Console.WriteLine("Mis aatal olete te sündinud?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int age = 2021 - YearOfBirth;
            Console.WriteLine("Oled praeguseks ajaks " + age);
            if (age >= 18)

            {
                Console.WriteLine("oled piisavalt vana, et saada auto load");
            }
            else 
            {
                Console.WriteLine("oled liiga noor, auto loade jaoks");
            }
            






        }
   
    
    
    }
}
