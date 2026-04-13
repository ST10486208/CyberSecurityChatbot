
using System;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer.PlayGreeting();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(AsciiArt.GetArt());

        Console.ResetColor();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Chatbot bot = new Chatbot(name);
        bot.Start();
    }
}