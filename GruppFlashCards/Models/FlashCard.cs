using System;
using System.Collections.Generic;

namespace GruppFlashCards.Models
{

public partial class FlashCard
{
        private static readonly Random random = new Random();
        public int FlashCardId { get; set; }

    public string FlashCardName { get; set; } = null!;

    public string? FlashCardDescription { get; set; }

    public string FlashCardQuestion { get; set; } = null!;

    public string FlashCardAnswer { get; set; } = null!;

    public int FlashCardDifficultyLevel { get; set; }

    public DateTime FlashCardInterval { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
        public FlashCard(string? flashcardname, string? flashcarddescription, string? flashcardquestion, string? flashcardanswer, int Category)
        {
            FlashCardId = random.Next(10, 100001);

            FlashCardName = flashcardname ?? "No Name Provided";
            FlashCardDescription = flashcarddescription   ?? "No Description Provided";
            FlashCardQuestion = flashcardquestion   ?? "No Question Provided";
            FlashCardAnswer = flashcardanswer   ?? "No Answer Provided";


            FlashCardDifficultyLevel = 1;
            FlashCardInterval = DateTime.Now;
            CategoryId = Category;
        }
        public FlashCard() // To help out the SQL
        {
            
        }
    }

}