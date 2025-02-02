using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System;
using GruppFlashCards.Models;
using Microsoft.EntityFrameworkCore;

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
            bool loggedin = false;

            while (!loggedin)
            {
                string userEmail = Utility.GetValidatedStringInput("Type your Email:");
                string userPassword = Utility.GetValidatedStringInput("Type your password:");
                var UserCurrentSession = _library.UserLogin(userEmail, userPassword);



                if (UserCurrentSession != null)
                {
                    loggedin = true;
                    while (running)
                    {
                        Console.Clear();
                        AnsiConsole.Markup($"[bold cyan]Welcome {UserCurrentSession?.UserName} to Flashcards App[/]\n");

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
                                loggedin = false;
                                running = false;
                                UserCurrentSession = null;
                                ShowMainMenu();
                                break;
                            case "5. Exit":
                                running = false;

                                break;
                            default:
                                AnsiConsole.MarkupLine("[red]Invalid option, please try again.[/]");
                                break;
                            case "6. Remove Flashcard":
                                RemoveFlashCard();
                                break;
                        }
                    }
                }
                else
                {
                    AnsiConsole.MarkupLine("[red]Invalid Login, please try again.[/]");
                    userEmail = Utility.GetValidatedStringInput("Type your Email:");
                    userPassword = Utility.GetValidatedStringInput("Type your password:");
                    UserCurrentSession = _library.UserLogin(userEmail, userPassword);
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