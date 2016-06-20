using Trivia.Models;

namespace Trivia.Infrastructure.Repositories.Abstract
{
    public interface IQuestionRepository : IModelRepository<Question> 
    {
	    Question GetRandom();
    }
    public interface IAnswerRepository : IModelRepository<Answer> {}

}