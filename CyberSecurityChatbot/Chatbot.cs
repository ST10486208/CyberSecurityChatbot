
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
        Console.WriteLine($"\nHello {userName}! \"CyberSafe Buddy is ready! ,Ask me anything about cybersecurity.");

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
                Console.WriteLine(" Cyberbuddy Bot: Stay safe online! Goodbye!");
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
            Console.WriteLine("Bot:Your password is your first line of defense! Make it strong: use at least 12 characters, mix upper and lower case letters, numbers, and symbols. Avoid personal info like birthdays or names. And remember—never reuse the same password across accounts.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Bot: Think before you click! Phishing emails often look real but hide dangerous traps. Always check the sender’s address, avoid clicking suspicious links, and never share personal information through unexpected messages. Outsmart the phishers—your data depends on it!.");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Bot: Browse smart, stay safe! Always check that websites start with ‘https://’, avoid clicking on suspicious pop-ups, and never download files from untrusted sources. Protect your privacy by keeping your browser and security software up to date");
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