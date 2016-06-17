using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;

namespace Trivia.Infrastructure.Repositories
{
    public class AnswerRepository : ModelBaseRepository<Answer> , IAnswerRepository
    {
        public AnswerRepository(TriviaContext context) : base(context)
        { }
    }
}