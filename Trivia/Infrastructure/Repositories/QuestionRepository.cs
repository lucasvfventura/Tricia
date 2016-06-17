using System.Linq;
using Microsoft.EntityFrameworkCore;
using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;
using System;

namespace Trivia.Infrastructure.Repositories
{
    public class QuestionRepository : ModelBaseRepository<Question> , IQuestionRepository
    {
        public QuestionRepository(TriviaContext context) : base(context)
        { }

        public Question GetRandom()
        {
            var count = context.Questions.Count();
            return context.Questions.Include(q => q.Answers).Skip(new Random().Next(count)).First();
        }
    }
}