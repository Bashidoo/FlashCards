using System;
using System.Linq;
using GruppFlashCards;
using GruppFlashCards.Models; 
using Microsoft.EntityFrameworkCore;

namespace GruppFlashCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dBContext = new BusherSundayContext();
            Library library = new Library(dBContext);
            Menu menu = new Menu(library);


            menu.ShowMainMenu();

            dBContext.SaveChanges();

            dBContext.Dispose();
  
            // SQL Integration! -------------
        }
    }
}
