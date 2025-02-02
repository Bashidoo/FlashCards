using GruppFlashCards.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace GruppFlashCards
{
    public class Library
    {

        private BusherSundayContext _dbContext;
        public List<User> users { get; set; }
        public List<Category> categories { get; set; }
        public List<FlashCard> flashcards { get; set; }


        // Since we are not going to push sql queries directly from Library. a constructor is needed.

        public Library(BusherSundayContext dbContext)
        {
            _dbContext = dbContext;
            List<GruppFlashCards.Models.User> users = _dbContext.Users.ToList();
            List<GruppFlashCards.Models.Category> categories = _dbContext.Categories.ToList();
            List<GruppFlashCards.Models.FlashCard> flashcards = _dbContext.FlashCards.ToList();

        }
        // implement functions and create instances of Users and FlashCards as a list.



        // Show Card

        public void ShowFlashCards()
        {

            var flashCards = _dbContext.FlashCards.ToList();
            if (_dbContext.FlashCards == null)
            {
                AnsiConsole.WriteLine("[red]No flash cards found![/]");
                return;
            }
            else if (!flashCards.Any())
            {
                AnsiConsole.WriteLine("[red]No flash cards found![/]");
            }
            else
            {
                foreach (var card in flashCards)
                {
                    AnsiConsole.WriteLine($"[blue]ID:{card.FlashCardId} {card.FlashCardName}: {card.FlashCardQuestion}");
                }
            }
          

        }

        // Show Category Table
        public void ShowCategoryTable()
        {
            
            if (!categories.Any())
            {
                AnsiConsole.WriteLine("[red]No categories cards found![/]");
                return;
            }

            var categorytable = new Table();
            categorytable.AddColumn("Category ID");
            categorytable.AddColumn("Category Name");
            categorytable.AddColumn("Nr. FlashCards");
            
            foreach (var category in categories)
            {
            
                    categorytable.AddRow(category.CategoryId.ToString(), 
                    category.CategoryName,
                    returnFlashCardCountByCategory(category.CategoryId).ToString());

            }

            AnsiConsole.Write(categorytable); 

        }

        public int returnFlashCardCountByCategory(int categoryID) // Suiiiiiiiiiii
        {
                                     
                return flashcards.Count(a => a.CategoryId == categoryID);

        }
        public void ReviewFlashCardsByCategory(int categoryID)
        {
            // Add logic First or default

            var categoryExist = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == categoryID);
            if (categoryExist == null)
            {
                AnsiConsole.WriteLine($"[red]Category:{categoryID} not found![/]");
                return;                 
                    
            }

            var flashcardInCategory = _dbContext.FlashCards.Where(a => a.CategoryId == categoryID && DateTime.Now >= a.FlashCardInterval).ToList();

            if (!flashcardInCategory.Any())
            {
                AnsiConsole.WriteLine($"[yellow]No flashcards are due for review in category '{categoryExist.CategoryName}'.[/]");
                return;
            }

            foreach (var flashcard in flashcardInCategory)
            {
                AnsiConsole.WriteLine($"[yellow]Question:[/] {flashcard.FlashCardQuestion}");

                string userAnswer = Utility.GetValidatedStringInput("Your answer:");

                if (userAnswer.Trim().Equals(flashcard.FlashCardAnswer.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    
                        AnsiConsole.MarkupLine("[green]Correct![/]");
                        UpdateSpacedRepitition(flashcard, true);
                    

                }
                else
                {
                    AnsiConsole.MarkupLine($"[red]Incorrect![/] The correct answer is: {flashcard.FlashCardAnswer}");
                    UpdateSpacedRepitition(flashcard, false);
                }
                AnsiConsole.MarkupLine($"[blue]Next review for this flashcard is on: {flashcard.FlashCardInterval}[/]");

            }
        }

        public void RemoveFlashCardFromList(int cardID)
        {
            FlashCard? flashCardExists = _dbContext.FlashCards.FirstOrDefault(x => x.FlashCardId == cardID);

            if (flashCardExists != null)
            {
                _dbContext.FlashCards.Remove(flashCardExists);

                _dbContext.SaveChanges();


            }
            
        }





        // In-memory list

        public void AddFlashCardToLocalList(FlashCard card)
        {
            if (_dbContext == null)
            {
                Console.WriteLine("Error: Database context is null!");
                return;
            }


            if (string.IsNullOrWhiteSpace(card.FlashCardAnswer))
            {
                card.FlashCardAnswer = "No answer provided";
            }

            if (card.FlashCardId == 0) // Ensure ID is set
            {
                card.FlashCardId = new Random().Next(1, 10000);
            }

               var categoryExist = _dbContext.Categories.FirstOrDefault(c => c.CategoryId == card.CategoryId);

            if (categoryExist != null)
            {
            _dbContext.FlashCards.Add(card);
            }
            else
            {
                AnsiConsole.MarkupLine("[red]No Category found! please consider adding card to following category or contact provider to create a new one![/]");
            }
            int changes = _dbContext.SaveChanges();

            Console.WriteLine($"{changes} record(s) added.");
        }


        public void UpdateSpacedRepitition(FlashCard flashcard, bool iscorrect)
        {

            if (iscorrect)
            {

                flashcard.FlashCardInterval = flashcard.FlashCardInterval.AddDays(flashcard.FlashCardDifficultyLevel * 2);
                _dbContext.SaveChanges();
            }
            else
            {

             flashcard.FlashCardInterval = DateTime.Now.AddDays(0);
                _dbContext.SaveChanges();
            }

            AnsiConsole.MarkupLine($"[blue]Next review for this flashcard is on: {flashcard.FlashCardInterval}[/]");
        }

        public User? UserLogin(string email, string password)
        {
            AnsiConsole.WriteLine($"Attempting to log in with Email: '{email}', Password: '{password}'");

            // Search for a matching user
            return _dbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);


        }

    }
}
