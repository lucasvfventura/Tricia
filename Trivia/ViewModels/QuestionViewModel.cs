using System.Collections.Generic;

namespace Trivia.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<AnswerViewModel> Answers { get; set; }
    }
}
