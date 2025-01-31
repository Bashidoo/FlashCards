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

        public List <FlashCard> flashcards { get; set; }
        public List <Users> users { get; set; }
        public List <Category> categories { get; set; }


        // Since we are not going to push sql queries directly from Library. a constructor is needed.

        public Library(List<Users> Users, List<Category> Categories, List<FlashCard> Flashcards)
        {
            users = Users;
            categories = Categories;
            flashcards = Flashcards;
        }
        // implement functions and create instances of Users and FlashCards as a list.



        // Show Card

        public void ShowFlashCards()
        {

            if (!flashcards.Any())
            {
                AnsiConsole.WriteLine("[red]No flash cards found![/]");
                return;
            }
            else
            {

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
            
                    categorytable.AddRow(category.categoryID.ToString(), 
                    category.categoryName,
                    returnFlashCardCountByCategory(category.categoryID).ToString());

            }

            AnsiConsole.Write(categorytable); 

        }

        public int returnFlashCardCountByCategory(int categoryID) // Suiiiiiiiiiii
        {
                                     
                return flashcards.Count(a => a.CategoryID == categoryID);

        }
        public void ReviewFlashCardsByCategory(int categoryID)
        {
            // Add logic First or default

            var categoryExist = categories.FirstOrDefault(x => x.categoryID == categoryID);
            if (categoryExist == null)
            {
                AnsiConsole.WriteLine("[red]Category not found![/]");
                return;                 
                    
            }

            var flashcardInCategory = flashcards.Where(a => a.CategoryID == categoryID && DateOnly.FromDateTime(DateTime.Now) >= a.flashCardInterval).ToList();

            if (flashcardInCategory == null)
            {
                AnsiConsole.WriteLine($"[yellow]No flashcards are due for review in category '{categoryExist.categoryName}'.[/]");
                return;
            }

            foreach (var flashcard in flashcardInCategory)
            {
                AnsiConsole.WriteLine($"[yellow]Question:[/] {flashcard.flashCardQuestion}");

                string userAnswer = Utility.GetValidatedStringInput("Your answer:");

                if (userAnswer.Trim().Equals(flashcard.flashCardAnswer.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    
                        AnsiConsole.MarkupLine("[green]Correct![/]");
                        UpdateSpacedRepitition(flashcard, true);
                    

                }
                else
                {
                    AnsiConsole.MarkupLine($"[red]Incorrect![/] The correct answer is: {flashcard.flashCardAnswer}");
                    UpdateSpacedRepitition(flashcard, false);
                }
                AnsiConsole.MarkupLine($"[blue]Next review for this flashcard is on: {flashcard.flashCardInterval}[/]");

            }
        }

        public void RemoveFlashCard(FlashCard card)
        {
            if (card != null)
            {
                flashcards.Remove(card);
            }
            else
            {
                AnsiConsole.WriteLine("[red]Invalid FlashCard.[/]");
            }
        }

        public void AddFlashCard(FlashCard card)
        {
            if (card != null)
            {
                flashcards.Add(card);
                AnsiConsole.WriteLine("[Green] FlashCard Added![/]");
            }
            else
            {
                AnsiConsole.WriteLine("[red]Invalid FlashCard.[/]");
            }

        }
        public void UpdateSpacedRepitition(FlashCard flashcard, bool iscorrect)
        {

            if (iscorrect)
            {

                flashcard.flashCardInterval = flashcard.flashCardInterval.AddDays(flashcard.flashCardDifficultyLevel * 2);
            }
            else
            {

            flashcard.flashCardInterval = DateOnly.FromDateTime(DateTime.Now).AddDays(0);
            }

            AnsiConsole.MarkupLine($"[blue]Next review for this flashcard is on: {flashcard.flashCardInterval}[/]");
        }

        public Users? UserLogin(string email, string password)
        {
            AnsiConsole.WriteLine($"Attempting to log in with Email: '{email}', Password: '{password}'");

            // Search for a matching user
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user != null)
            {
                AnsiConsole.WriteLine("[green]Login successful![/]");
                return user;
            }

            AnsiConsole.WriteLine("[red]Invalid email or password.[/]");
            return null;
        }

    }
}
