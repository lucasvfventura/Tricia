namespace Trivia.Models
{
    public class UserAnswer : IModelBase
    {
        public int Id { get; set; }
        
        public User User { get; set; }

        public string UserId { get; set; }

        public Answer Answer { get; set; }

        public int AnswerId { get; set; }

        public Question Question { get; set; }

        public int QuestionId { get; set; }
    }
}
