using System.Text;
using System;
namespace TicketSystem
{ 
    class GenerateRandomString
    {
        static void Main()
        {
            Console.WriteLine("Enter amount of tickets:");
            int ticketAmount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < ticketAmount)
            {
                int length = 14;

                StringBuilder str_build = new StringBuilder();
                Random random = new Random();

                char letter;
            
                for (int i = 0; i < length; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                Console.WriteLine("Your ticketID is:");
                System.Console.WriteLine(str_build.ToString());
                count++;
            }
            

            
            
        }
}}