using Spectre.Console;
using System;

namespace GruppFlashCards
{
    public class Menu
    {
        private Library _library = new Library(); // Instance of Library class

        public void ShowMainMenu()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                AnsiConsole.Markup("[bold cyan]Welcome to Flashcards App[/]\n");

                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[yellow]Select an option:[/]")
                        .AddChoices("1. Add Flashcard", "2. Show Flashcards", "3. Review Flashcards", "4. User Login", "5. Exit")
                );

                switch (choice)
                {
                    case "1. Add Flashcard":
                        AddFlashCard();
                        break;
                    case "2. Show Flashcards":
                        _library.ShowFlashCards();
                        Console.ReadKey();
                        break;
                    case "3. Review Flashcards":
                        _library.ReviewFlashCards();
                        Console.ReadKey();
                        break;
                    case "4. User Login":
                        UserLogin();
                        break;
                    case "5. Exit":
                        running = false;
                        break;
                    default:
                        AnsiConsole.MarkupLine("[red]Invalid option, please try again.[/]");
                        break;
                }
            }
        }

        private void AddFlashCard()
        {
            Console.Clear();
            AnsiConsole.MarkupLine("[yellow]Add a New Flashcard[/]");

            string question = Utility.GetValidatedStringInput("Enter the question:");
            string answer = Utility.GetValidatedStringInput("Enter the answer:");

            FlashCard card = new FlashCard(question, answer);
            _library.AddFlashCard(card);

            AnsiConsole.MarkupLine("[green]Flashcard Added Successfully![/]");
        }

        private void UserLogin()
        {
            bool loggingIn = true;
            while (loggingIn)
            {
                string userEmail = Utility.GetValidatedStringInput("Please Enter your Email: ").Trim();
                string password = Utility.GetValidatedStringInput("Enter your password:").Trim();

                Users? loggedInUser = _library.UserLogin(userEmail, password);

                if (loggedInUser != null)
                {
                    loggingIn = false;
                    AnsiConsole.MarkupLine($"[green]Welcome: {loggedInUser.Email}[/]");
                    // Go to the main menu or perform other actions
                }
                else
                {
                    AnsiConsole.MarkupLine("[red]Login failed. Please try again.[/]");
                }
            }
        }
    }
}
