using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            do
            {
               Console.Write("Place your question: ");
               question = Console.ReadLine();
               switch(question)
               {
                  case "How are you?":
                   response = "I'm fine, thank you";
                   break;

                  case "Are you an AI?":
                   response = "No, I'm not";
                   break;
                  
                  case "Can you do math?":
                   response = "Not yet, my dev didn't coded me to do that yet";
                   break;
                  
                  case "Are you smart enough?":
                   response = "Nope, I'm dumb as a stone";
                   break;
                  
                  default:
                   response = "Sorry I'm not able to answer that question";
                   break;
               }

               Console.WriteLine(response);
            }
            while(question != "EXIT");
        }
    }
}
