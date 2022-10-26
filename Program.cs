using System;
using PetersTests.Solutions;

Console.WriteLine("Program start!");

while (true)
{


    Console.WriteLine("Enter command");
    string input = Console.ReadLine();

    bool quit = HandleInput(input);

    if (quit)
    {
        break;
    }
}

bool HandleInput(string input)
{
    switch (input)
    {
        case "h":
            DisplayHelp();
            return false;
        case "help":
            DisplayHelp();
            return false;
        case "1":
            Console.WriteLine("run test 1");
            Test1.Solution(new int[] { });
            return false;
        case "2":
            Console.WriteLine("run test 2");
            Test2.Solution("Hello there. General Kenobi.");
            return false;
        case "q":
            Console.WriteLine("quit command");
            return true;
        case "quit":
            Console.WriteLine("quit command");
            return true;
        case "exit":
            Console.WriteLine("quit command");
            return true;
        default:
            Console.WriteLine("unknown command");
            return false;
    }

}

void DisplayHelp()
{
    Console.WriteLine("Available commands");
    Console.WriteLine("h, help : Display's information on available commands");
    Console.WriteLine("test1 : Runs Test1");
    Console.WriteLine("test2 : Runs Test2");
    Console.WriteLine("q, quit, exit : Quits the program");
}