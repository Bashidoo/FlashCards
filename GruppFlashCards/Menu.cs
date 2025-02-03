using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System;
using GruppFlashCards.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GruppFlashCards
{
    public class Menu
    {
        private BusherSundayContext _dbContext;
        private Library _library; // Instance of Library class

        public Menu(Library library)
        {
            _library = library;
        }
        public void ShowMainMenu()
        {
            if (_library == null)
            {
                Console.WriteLine("Library is not initialized.");
                return;
            }
            bool running = true;
            User? UserCurrentSession = null;

            while (UserCurrentSession == null)
            {
                var choice1 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[cyan]What would you like to do?[/]")
                        .AddChoices("Create User", "Login", "Exit"));

                switch (choice1)
                {
                    case "Create User":
                        _library.AskInfoForUserOBJ();
                        break;

                    case "Login":
                        string email = Utility.GetValidatedStringInput("Please enter your [yellow]User Email[/]:");
                        string password = Utility.GetValidatedStringInput("Please enter your [yellow]Password[/]:");

                        AnsiConsole.Status().Start("Logging in...", ctx =>
                        {
                            UserCurrentSession = _library.UserLogin(email, password);
                        });

                        if (UserCurrentSession == null)
                        {
                            AnsiConsole.MarkupLine("[red]Invalid credentials, please try again.[/]");
                        }
                        break;

                    case "Exit":
                        AnsiConsole.MarkupLine("[green]Thank you for using FlashCard app. Goodbye![/]");
                        return; // Exit program
                }
            }


            RunMainMenu(UserCurrentSession);
        }


        private void RunMainMenu(User UserCurrentSession)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                AnsiConsole.Markup($"[bold cyan]Welcome {UserCurrentSession.UserName} to Flashcards App[/]\n");

                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[yellow]Select an option:[/]")
                        .AddChoices("1. Add Flashcard", "2. Show Flashcards", "3. Review Flashcards", "4. Logout", "5. Exit", "6. Remove Flashcard")
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
                        int categoryIdInput = Utility.GetValidatedNumberInput("Type Category ID:");
                        _library.ReviewFlashCardsByCategory(categoryIdInput);
                        Console.ReadKey();
                        break;
                    case "4. Logout":
                        AnsiConsole.MarkupLine("[yellow]Logging out...[/]");
                        UserCurrentSession = null;
                        ShowMainMenu();
                        break; // Back to login menu
                    case "5. Exit":
                        running = false;
                        return;
                    case "6. Remove Flashcard":
                        RemoveFlashCard();
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

            string name = Utility.GetValidatedStringInput("Enter the flashcard name:");
            string description = Utility.GetValidatedStringInput("Enter the description of the flashcard:");
            string question = Utility.GetValidatedStringInput("Enter the question:");
            string answer = Utility.GetValidatedStringInput("Enter the answer:");
            int category = Utility.GetValidatedNumberInput("Enter CategoryID:");

         
                FlashCard card = new FlashCard(name, description, question, answer, category);
                _library.AddFlashCardToLocalList(card);
       
          
           
              
        }
        
        private void RemoveFlashCard()
        {
            Console.Clear();
            AnsiConsole.MarkupLine("[red]Remove a Flashcard[/]");

            int flashcardID = Utility.GetValidatedNumberInput("Enter FlashCardID to remove:");
            _library.RemoveFlashCardFromList(flashcardID);
        }
 
    }
}