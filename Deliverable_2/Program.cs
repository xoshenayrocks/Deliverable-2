using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            string inputCap = input.ToUpper();
           
            string message = " ";
            int checksum = 0; 
             
            foreach (char x in inputCap)
                
                {
                 
                int result = (int)x - 64;
             
                 message += result.ToString() + "-";
                
                checksum += (int)x;
                    
                }

            Console.WriteLine("Your encoded message is" + message);

            Console.WriteLine("Message checksum is " + checksum);
        
        }
    }

}

