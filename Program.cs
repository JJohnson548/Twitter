namespace Twitter
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //promting user for their message
            Console.WriteLine("Create a new message");

            string userMessage = Console.ReadLine();

            //getting length of user message
            int userMessageLength = userMessage.Length;

            //evaluating if message can be posted
            if (userMessageLength <= 140)
            {

                Console.WriteLine("\nPosted");
            }
            else { 
                
                Console.WriteLine("\nRejected");
              
      
            }

        }
    }
}
