using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;
using Trivia.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Trivia.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private IQuestionRepository qRepository;
        private IAnswerRepository aRepository;

        public QuestionController(IQuestionRepository qRepository, IAnswerRepository aRepository)
        {
            this.qRepository = qRepository;
            this.aRepository = aRepository;
        }

        public IEnumerable<QuestionViewModel> Get()
        {
            var questions = qRepository.GetAll();
            return Mapper.Map<IEnumerable<Question>, IEnumerable<QuestionViewModel>>(questions);
        }

        [HttpGet("random")]
        public QuestionViewModel Random()
        {
            var question = qRepository.GetRandom();
            aRepository.FindBy(a => a.QuestionId == question.Id).ToList();
            return Mapper.Map<Question, QuestionViewModel>(question);
        }

        [HttpPost("{id}/answer")]
        public bool Post(int id, [FromBody] AnswerViewModel answerViewModel)
        {
            //var question = qRepository.GetSingle(id);
            if (ModelState.IsValid)
            {
                var answer = aRepository.GetSingle(answerViewModel.Id);
                if(answer.QuestionId == id)
                {
                    // TODO: add answer to logged user
                    return answer.IsCorrect;
                }
            }
            
            // TODO: return erro
            return false;
        }

        public IActionResult Error()
        {
            return null;
        }
    }
}
