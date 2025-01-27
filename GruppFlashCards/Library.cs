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

        public List <FlashCard> flashcards { get; set; } = new List <FlashCard> ();
        public List <Users> users { get; set; } = new List <Users> ();
        // implement functions and create instances of Users and FlashCards as a list.

        

        // Show Card

        public void ShowFlashCards()
        {

            if (!flashcards.Any())
            {
                AnsiConsole.WriteLine("[red]No flash cards found![/]");
                return;
            }

        }
        // Reviewing card

        public void ReviewFlashCards()
        {
            
            if (!flashcards.Any())
            {
                AnsiConsole.WriteLine("[red]No flash cards found![/]");
            }
            else
            {
                // Add Logic
            }
        }

        

        public void AddFlashCard(FlashCard card)
        {
            if (card != null)
            {
                flashcards.Add (card);
            }
            else
            {
                AnsiConsole.WriteLine("[red]Invalid email or password.[/]");
            }

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
