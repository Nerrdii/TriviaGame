namespace DataAccessClassLibrary.Models
{
    public class MultipleChoiceQuestion
    {
        public int QuestionID { get; set; }

        public string Question { get; set; }

        public int CorrectAnswerID { get; set; }

        public string CorrectAnswer { get; set; }

        public string SecondAnswer { get; set; }

        public string ThirdAnswer { get; set; }

        public string FourthAnswer { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }
    }
}
