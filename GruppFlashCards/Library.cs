using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GruppFlashCards
{
    public class Library
    {
        public List<FlashCard> Flashcards { get; set; } = new List<FlashCard>();
        public List<Users> Users { get; set; } = new List<Users>();

        public void ShowFlashCards()
        {
            if (!Flashcards.Any())
            {
                AnsiConsole.MarkupLine("[red]No flashcards found![/]");
                return;
            }

            var table = new Table();
            table.AddColumn("[yellow]Question[/]");
            table.AddColumn("[green]Answer[/]");

            foreach (var card in Flashcards)
            {
                table.AddRow(card.Question, card.Answer);
            }

            AnsiConsole.Write(table);
        }

        public void AddFlashCard(FlashCard card)
        {
            Flashcards.Add(card);
        }

        public Users? UserLogin(string email, string password)
        {
            var user = Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public void ReviewFlashCards()
        {
            if (!Flashcards.Any())
            {
                AnsiConsole.WriteLine("[red]No flashcards available for review![/]");
                return;
            }

            foreach (var card in Flashcards)
            {
                AnsiConsole.MarkupLine($"[yellow]Question:[/] {card.Question}");
                AnsiConsole.MarkupLine($"[green]Answer:[/] {card.Answer}");
                AnsiConsole.MarkupLine("\n[bold blue]Press any key to continue to the next card.[/]");
                Console.ReadKey();
            }
        }
    }
}
