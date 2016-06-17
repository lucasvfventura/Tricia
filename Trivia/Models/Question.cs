using System.Collections.Generic;

namespace Trivia.Models
{
    public class Question : IModelBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
