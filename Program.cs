using System;
using System.Net.Http.Headers;

class Program
{
    public static void Main(string[] args)
    {
        PrintMenu();
        InputOption();
        GetMessage();
    }

    void PrintMenu()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French? ");
            Console.WriteLine("2. Hello in Spanish? ");
            Console.WriteLine("3. Hello in German? ");
            Console.WriteLine("4. Hello in Italian? ");
            Console.WriteLine("0. Exit Application ");
            Console.Write("Choose an option: ");

            // Accept the user's choice
            string userChoice = Console.ReadLine();
            InputOption(userChoice);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    void InputOption(string userChoice)
    {
        switch (userChoice)
        {
            case "1":
            case "2":
            case "3":
            case "4":
                GetMessage(userChoice);
                PrintMenu();
                break;
            case "0":
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Invalid choice, please try again");
                PrintMenu();
                break;
        }
    }

    void GetMessage(string userChoice)
    {
        switch (userChoice)
        {
            case "1":
                // Add your response here
                Console.WriteLine("Bonjour");
                Console.ReadKey();
                break;
            case "2":
                Console.WriteLine("Hola");
                Console.ReadKey();
                break;
            case "3":
                Console.WriteLine("Hallo");
                Console.ReadKey();
                break;
            case "4":
                Console.WriteLine("Ciao");
                Console.ReadKey();
                break;
            case "0":
                Console.WriteLine("Goodbye");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Invalid choice, please try again");
                break;
        }
    }
}