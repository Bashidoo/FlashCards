using System;
using System.Collections.Generic;
using System.Linq;
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

        // Choose card

        // Moving Card to System.


        public Users? UserLogin(string email, string password)
        {
            Console.WriteLine($"Attempting to log in with Email: '{email}', Password: '{password}'");

            // Search for a matching user
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user != null)
            {
                Console.WriteLine("[green]Login successful![/]");
                return user;
            }

            Console.WriteLine("[red]Invalid email or password.[/]");
            return null;
        }

    }
}
