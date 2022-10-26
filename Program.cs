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
        case "test1":
            Console.WriteLine("running test 1");
            var inputData = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Input data: { 1, 2, 3, 4 }");
            Console.WriteLine("Smallest value not in use: " + Test1.Solution(inputData));
            return false;
        case "test2":
            Console.WriteLine("running test 2");
            string inputString = "Hello there. General Kenobi. How is your mother doing these days?";
            Console.WriteLine("Input data: " + inputString);
            Console.WriteLine("Highest word Count: " +  Test2.Solution(inputString));
            return false;
        case "q":
            Console.WriteLine("quitting");
            return true;
        case "quit":
            Console.WriteLine("quitting");
            return true;
        case "exit":
            Console.WriteLine("quitting");
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