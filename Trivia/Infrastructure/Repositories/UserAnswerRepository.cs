using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;

namespace Trivia.Infrastructure.Repositories
{
    public class UserAnswerRepository : ModelBaseRepository<UserAnswer> , IUserAnswerRepository
    {
        public UserAnswerRepository(TriviaContext context) : base(context)
        { }
    }
}