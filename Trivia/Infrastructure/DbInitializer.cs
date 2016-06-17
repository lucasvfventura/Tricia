using System;
using System.Collections.Generic;
using System.Linq;
using Trivia.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Trivia.Infrastructure
{
    public static class DbInitializer
    {
        private static TriviaContext context;
        public static void Init(IServiceProvider provider)
        {
            context = (TriviaContext)provider.GetService<TriviaContext>();
            InitQuestions();
        }

        private static void InitQuestions()
        {
            if (context.Questions.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var myAnswers = new List<Answer>();
                    for (int j = 0; j < 5; j++)
                    {
                        var answer = context.Answers.Add(new Answer()
                        {
                            Text = $"{i + j}",
                            IsCorrect = j == 2
                        }).Entity;
                        myAnswers.Add(answer);
                    }
                    
                    context.Questions.Add(new Question()
                    {
                        Title = $"{i} + 2?",
                        Answers = myAnswers
                    });
                }
                
                context.SaveChanges();
            }
        }
    }
}
