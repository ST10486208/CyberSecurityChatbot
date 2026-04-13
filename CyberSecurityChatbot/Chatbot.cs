
using System;

public class Chatbot
{
    private string userName;

    public Chatbot(string name)
    {
        userName = name;
    }

    public void Start()
    {
        Console.WriteLine($"\nHello {userName}! \"CyberSafe Buddy is ready!\"Ask me anything about cybersecurity.");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (InputHandler.IsInvalid(input))
            {
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Bot: Stay safe online! Goodbye!");
                break;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        input = input.ToLower();

        if (input.Contains("password"))
        {
            Console.WriteLine("Bot: Use strong passwords with a mix of letters, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Bot: Be careful of suspicious emails and never click unknown links.");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Bot: Always check for HTTPS and avoid downloading from unknown sites.");
        }
        else if (input.Contains("how are you"))
        {
            Console.WriteLine("Bot: I'm just code, but I'm here to help you stay safe!");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("Bot: My purpose is to educate you about cybersecurity.");
        }
        else
        {
            Console.WriteLine("Bot: That's interesting! Can you ask something about cybersecurity?");
        }
    }
}