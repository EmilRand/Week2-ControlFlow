using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
              //program küsib kasutaja vanust
              //kui kasutaja on vanem kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
              //Kui kasutaja on noorem kui 18, siis kosoolis kuvatakse "oled liiga noor"
              //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"  
              Console.WriteLine("Kui vana te olete?");
              int age = Convert.ToInt32(Console.ReadLine());
              if (age > 18)
              {
                Console.WriteLine("oled piisavalt vana");
              }
               else if (age < 18)
               {
                Console.WriteLine("oled liiga noor");
               }
 
              else
              {
                Console.WriteLine("oledki 18");
              }

            Console.WriteLine("Kena Päeva!");
        
        }
    }
}
