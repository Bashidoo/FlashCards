using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppFlashCards
{
    public class FlashCard
    {
        private static readonly Random random = new Random();
        public int flashCardID { get; set; }

        public string flashCardName { get; set; }

        public string flashCardDescription { get; set; }

        public string flashCardQuestion { get; set; }

        public string flashCardAnswer { get; set; }

        public int flashCardDifficultyLevel { get; set; }

        public DateOnly flashCardInterval { get; set; }

        // Foreign Key
        public int CategoryID { get; set; }


        public FlashCard()
        {
            
        }
        public FlashCard(string? flashcardname, string? flashcarddescription, string? flashcardquestion, string? flashcardanswer)
        {
            flashCardID = random.Next(10, 100001);
            flashcardname = flashCardName;
            flashcarddescription = flashCardDescription;
            flashcardquestion = flashCardQuestion;
            flashcardanswer = flashCardAnswer;
            flashCardDifficultyLevel = 1;
            flashCardInterval = DateOnly.FromDateTime(DateTime.Now);


        }

        public bool IsDue()
        {
            return DateOnly.FromDateTime(DateTime.Now) >= flashCardInterval;
        }

        public string ToString()
        {
            return $"Name:{flashCardName} ID: {flashCardID}, Question: {flashCardQuestion} ";
        }
    }
}
