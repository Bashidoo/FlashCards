namespace GruppFlashCards
{
    public class FlashCard
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public FlashCard(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
